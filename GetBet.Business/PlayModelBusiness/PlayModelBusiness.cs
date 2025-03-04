using GetBet.Business.MatchBusiness;
using GetBet.Business.Models;
using GetBet.Business.NesineCom;
using GetBet.Business.NesineCom.Models.ResponseModels;
using GetBet.Business.Sportradar;
using GetBet.Core.Helpers;
using GetBet.Core.Repository.Abstract;
using GetBet.Core.Repository.Concrete;
using GetBet.Core.Settings;
using GetBet.Entities.Concrete;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetBet.Business.PlayModelBusiness
{
    public class PlayModelBusiness
    {
        IUnitOfWork _unitOfWork;

        public NesineComManager NesineComManager { get; set; }
        public MatchRatioCalculationBusiness MatchRatioCalculationBusiness { get; set; }
        public SportradarManager SportradarManager { get; set; }

        public PlayModelBusiness(MongoSettings settings)
        {

            _unitOfWork = new UnitOfWork(settings);
            NesineComManager = new NesineComManager();
            MatchRatioCalculationBusiness = new MatchRatioCalculationBusiness();
            SportradarManager = new SportradarManager();
        }
        public PlayModelBusiness()
        {
            NesineComManager = new NesineComManager();
            MatchRatioCalculationBusiness = new MatchRatioCalculationBusiness();
            SportradarManager = new SportradarManager();
        }
        public void OneAndHalfOverMatches()
        {
            BulletinResponseModel bulletinResponseModel = NesineComManager.GetPreBulletinFull().Result;

            var playModels = MatchRatioCalculationBusiness.FindOneAndHalfOverMatches(bulletinResponseModel);

            string jsonPlayModelsOneAndHalfOver = JsonConvert.SerializeObject(playModels.OrderBy(x => x.DateTime));

            if (!string.IsNullOrEmpty(jsonPlayModelsOneAndHalfOver))
            {
                DataTable dt = (DataTable)JsonConvert.DeserializeObject(jsonPlayModelsOneAndHalfOver, (typeof(DataTable)));

                MailHelper.SendMail(CHelper.MailToAdresses(), "1.5 üst Oynanabilecek Maçlar", CHelper.ConvertDataTableToHTML(dt));

            }
        }

        /// <summary>
        /// Oynanabilecek olan maçları DB'ye kayıt eder ve mail gönderir.
        /// </summary>
        public void AddDBAndSendMailPlayModel()
        {
            BulletinResponseModel bulletinResponseModel = NesineComManager.GetPreBulletinFull().Result;

            var playModels = MatchRatioCalculationBusiness.MutualScoringMatch(bulletinResponseModel);

            //playModels.AddRange(MatchRatioCalculationBusiness.FirstHalfDrawMatchs(bulletinResponseModel));

            playModels.AddRange(MatchRatioCalculationBusiness.FirstHalfDrawMatchsV2(bulletinResponseModel));

            if (playModels.Count() > 0 && playModels != null)
            {
                foreach (var playModel in playModels)
                {
                    var dbModel = _unitOfWork.Plays.FilterBy(x => x.MatchId == playModel.MatchId);

                    if (dbModel.Result == null || dbModel.Result.Count() == 0)
                    {
                        playModel.ScoreTeam1 = null;
                        playModel.ScoreTeam2 = null;

                        _unitOfWork.Plays.InsertOne(playModel);

                    }

                }

                string jsonPlayModelsKGVar = JsonConvert.SerializeObject(playModels.Where(x => !x.IsIY0MS12).OrderBy(x => x.DateTime));

                string jsonPlayModelsIsIY0MS12 = JsonConvert.SerializeObject(playModels.Where(x => x.IsIY0MS12).OrderBy(x => x.DateTime));

                if (!string.IsNullOrEmpty(jsonPlayModelsKGVar))
                {
                    DataTable dt = (DataTable)JsonConvert.DeserializeObject(jsonPlayModelsKGVar, (typeof(DataTable)));

                    MailHelper.SendMail(CHelper.MailToAdresses(), "KG var Oynanabilecek Maçlar", CHelper.ConvertDataTableToHTML(dt));

                }
                if (!string.IsNullOrEmpty(jsonPlayModelsIsIY0MS12))
                {
                    DataTable dt2 = (DataTable)JsonConvert.DeserializeObject(jsonPlayModelsIsIY0MS12, (typeof(DataTable)));

                    MailHelper.SendMail(CHelper.MailToAdresses(), "IY 0 Oynanabilecek Maçlar", CHelper.ConvertDataTableToHTML(dt2));

                }
                Console.WriteLine($"Maçlar kaydedildi ve mail atıldı.");

            }

        }

        /// <summary>
        /// Maç sonucunu getirir ve DB'ye kayıt eder.
        /// </summary>
        public void GetMatchResultsAndSaveDB()
        {
            var playModels = _unitOfWork.Plays.FilterBy(x => x.DateTime < DateTime.Now && x.DateTime > DateTime.Now.AddDays(-5));

            foreach (var playModel in playModels.Result)
            {
                var result = SportradarManager.GetMatchResult(playModel.MatchId).Result;

                var matchResult = result.Doc.First().Data.Match.Result;

                if (matchResult == null || matchResult.Home == null || matchResult.Away == null)
                    continue;

                playModel.ScoreTeam1 = result.Doc.First().Data.Match.Result.Home.Value;
                playModel.ScoreTeam2 = result.Doc.First().Data.Match.Result.Away.Value;

                playModel.IYScoreTeam1 = result.Doc.First().Data.Match.Periods?.P1?.Home.Value;
                playModel.IYScoreTeam2 = result.Doc.First().Data.Match.Periods?.P1?.Away.Value;

                if (playModel.ScoreTeam1 > 0 && playModel.ScoreTeam2 > 0)
                    playModel.HasMutualScoring = true;

                if (playModel.ScoreTeam1 + playModel.ScoreTeam2 > 2)
                    playModel.TwoUpGoals = true;

                if (playModel.IYScoreTeam1 != null && playModel.IYScoreTeam2 != null)
                {
                    playModel.IsIY0 = false;

                    if (playModel.IYScoreTeam1 == playModel.IYScoreTeam2)
                        playModel.IsIY0 = true;

                }

                _unitOfWork.Plays.ReplaceOne(playModel, playModel.Id.ToString());
            }

            Console.WriteLine($"Maç sonuçları çekildi ve kaydedildi.");

        }

        /// <summary>
        /// Karşılıklı gol veya 2 gol üstü biten maçları çeker.
        /// </summary>
        /// <returns></returns>
        public List<Play> GetWinnerPlays()
        {
            List<Play> winnPlays = new List<Play>();

            winnPlays = _unitOfWork.Plays.FilterBy(x => x.DateTime.AddHours(3) < DateTime.Now && (x.TwoUpGoals || x.HasMutualScoring)).Result.ToList();

            return winnPlays;
        }

        /// <summary>
        /// Karşılıklı gol veya 2 gol üstü biten maçları ve tutmayan maçların sayılarını çeker.
        /// </summary>
        /// <returns></returns>
        public void GetAndAddPlayStats()
        {
            KGVarPlayStatus();

            IY0PlayStatus();

            Console.WriteLine($"İstatistikler hesaplandı ve eklendi.");
        }

        /// <summary>
        /// KG var olan maçların sonuçlarını hesaplar ve tabloya istatistiği yazar.
        /// </summary>
        private void KGVarPlayStatus()
        {
            StatsModel statsModel = new StatsModel();

            _unitOfWork.Stats.DeleteMany(x => x.Id != null);

            var finishedMatches = _unitOfWork.Plays.FilterBy(x => x.ScoreTeam1 != null && x.ScoreTeam2 != null && x.DateTime.AddHours(3) < DateTime.Now.AddHours(3) && !x.IsIY0MS12).Result.ToList();

            statsModel.TotalPlay = finishedMatches.Count();

            statsModel.HasMutualScoringPlay = finishedMatches.Where(x => x.HasMutualScoring).Count();

            statsModel.TwoUpGoalsPlay = finishedMatches.Where(x => x.TwoUpGoals).Count();

            statsModel.LosePlay = finishedMatches.Where(x => !x.TwoUpGoals && !x.HasMutualScoring).Count();

            string jsonstatsModels = JsonConvert.SerializeObject(statsModel);

            var stats = JsonConvert.DeserializeObject<Stats>(jsonstatsModels);

            stats.CreateDate = DateTime.Now.AddHours(3);

            int successMatch = stats.TotalPlay - stats.LosePlay;

            stats.SuccessRatio = (double)successMatch / stats.TotalPlay * 100;

            _unitOfWork.Stats.InsertOne(stats);
        }

        /// <summary>
        /// İlk yarı berabere olan maçların sonuçlarını hesaplar ve tabloya istatistiği yazar.
        /// </summary>
        private void IY0PlayStatus()
        {
            IY0StatsModel statsModel = new IY0StatsModel();

            _unitOfWork.IY0Stats.DeleteMany(x => x.Id != null);

            var finishedMatches = _unitOfWork.Plays.FilterBy(x => x.IYScoreTeam1 != null && x.IYScoreTeam2 != null && x.DateTime.AddHours(3) < DateTime.Now.AddHours(3) && x.IsIY0MS12).Result.ToList();

            statsModel.TotalPlay = finishedMatches.Count();

            statsModel.IY0Play = finishedMatches.Where(x => x.IsIY0.Value == true).Count();

            statsModel.LosePlay = finishedMatches.Where(x => x.IsIY0.Value == false).Count();

            statsModel.CreateDate = DateTime.Now.AddHours(3);

            int successMatch = statsModel.TotalPlay - statsModel.LosePlay;

            statsModel.SuccessRatio = (double)successMatch / statsModel.TotalPlay * 100;

            _unitOfWork.IY0Stats.InsertOne(statsModel);
        }

    }
}
