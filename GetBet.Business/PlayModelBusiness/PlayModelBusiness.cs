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

        /// <summary>
        /// Oynanabilecek olan maçları DB'ye kayıt eder ve mail gönderir.
        /// </summary>
        public void AddDBAndSendMailPlayModel()
        {
            BulletinResponseModel bulletinResponseModel = NesineComManager.GetPreBulletinFull().Result;

            var playModels = MatchRatioCalculationBusiness.MutualScoringMatch(bulletinResponseModel);

            if (playModels.Count()>0 && playModels!=null)
            {
                foreach (var playModel in playModels)
                {
                    var dbModel = _unitOfWork.Plays.FilterBy(x => x.MatchId == playModel.MatchId);

                    if (dbModel.Result==null || dbModel.Result.Count()==0)
                        _unitOfWork.Plays.InsertMany(playModels);

                }

                string jsonPlayModels = JsonConvert.SerializeObject(playModels.OrderBy(x => x.DateTime));

                DataTable dt = (DataTable)JsonConvert.DeserializeObject(jsonPlayModels, (typeof(DataTable)));

                MailHelper.SendMail(CHelper.MailToAdresses(), "Oynanabilecek Maçlar", CHelper.ConvertDataTableToHTML(dt));
            }
           
        }

        /// <summary>
        /// Maç sonucunu getirir ve DB'ye kayıt eder.
        /// </summary>
        public void GetMatchResultsAndSaveDB()
        {
            var playModels = _unitOfWork.Plays.FilterBy(x=>x.DateTime<DateTime.Now && x.DateTime>DateTime.Now.AddDays(-5));

            foreach (var playModel in playModels.Result)
            {
                var result = SportradarManager.GetMatchResult(playModel.MatchId).Result;

                var matchResult = result.Doc.First().Data.Match.Result;

                if (matchResult==null || matchResult.Home==null || matchResult.Away==null) 
                    continue;

                playModel.ScoreTeam1 = result.Doc.First().Data.Match.Result.Home.Value;
                playModel.ScoreTeam2 = result.Doc.First().Data.Match.Result.Away.Value;

                if (playModel.ScoreTeam1 > 0 && playModel.ScoreTeam2 > 0)
                    playModel.HasMutualScoring = true;

                if(playModel.ScoreTeam1+playModel.ScoreTeam2>2)
                    playModel.TwoUpGoals = true;

                _unitOfWork.Plays.ReplaceOne(playModel,playModel.Id.ToString());
            }
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
        public StatsModel GetAndAddPlayStats()
        {
            StatsModel statsModel = new StatsModel();

            statsModel.TotalPlay = _unitOfWork.Plays.FilterBy(x => x.DateTime.AddHours(3) < DateTime.Now).Result.Count();

            statsModel.HasMutualScoringPlay = _unitOfWork.Plays.FilterBy(x => x.DateTime.AddHours(3) < DateTime.Now && x.HasMutualScoring).Result.Count();

            statsModel.TwoUpGoalsPlay = _unitOfWork.Plays.FilterBy(x => x.DateTime.AddHours(3) < DateTime.Now && x.TwoUpGoals).Result.Count();

            statsModel.LosePlay = _unitOfWork.Plays.FilterBy(x => x.DateTime.AddHours(3) < DateTime.Now && !x.TwoUpGoals && !x.HasMutualScoring).Result.Count();

            string jsonstatsModels = JsonConvert.SerializeObject(statsModel);

            var stats = JsonConvert.DeserializeObject<Stats>(jsonstatsModels);

            stats.CreateDate = DateTime.Now;

            int successMatch = stats.TotalPlay - stats.LosePlay;

            stats.SuccessRatio = (double)successMatch / stats.TotalPlay * 100;

            _unitOfWork.Stats.InsertOne(stats);

            return statsModel;
        }
    }
}
