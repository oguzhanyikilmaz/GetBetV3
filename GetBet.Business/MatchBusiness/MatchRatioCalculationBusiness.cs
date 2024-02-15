using GetBet.Business.NesineCom;
using GetBet.Business.NesineCom.Models.ResponseModels;
using GetBet.Entities.Concrete;
using System;

namespace GetBet.Business.MatchBusiness
{
    public class MatchRatioCalculationBusiness
    {
        public NesineComManager NesineComManager { get; set; }
        public MatchRatioCalculationBusiness()
        {
            NesineComManager = new NesineComManager();
        }
        /// <summary>
        /// Bültenden gelen response içinde KG var oynanabilicek maçları hesaplar.
        /// </summary>
        /// <param name="bulletinResponseModel"></param>
        /// <returns></returns>
        public List<Play> MutualScoringMatch(BulletinResponseModel bulletinResponseModel)
        {
            List<Play> playModels = new List<Play>();

            var mutualScoringMatches = bulletinResponseModel.sg.EA.Where(x => x.TYPE >= 1 && x.MA.Any(z => z.MTID == 43)).ToList();

            foreach (var match in mutualScoringMatches)
            {
                bool isAdded = false;

                Play playModel = new Play();

                playModel.MatchId = match.BRID.ToString();
                playModel.Team1 = match.HN;
                playModel.Team2 = match.AN;
                playModel.ZeroAndOneGoal = match.MA.FirstOrDefault(x => x.MTID == 43)?.OCA.FirstOrDefault(z => z.N == 1)?.O;
                playModel.FourFiveGoal = match.MA.FirstOrDefault(x => x.MTID == 43)?.OCA.FirstOrDefault(z => z.N == 3)?.O;
                playModel.MS1 = match.MA.FirstOrDefault(x => x.MTID == 1)?.OCA.FirstOrDefault(z => z.N == 1)?.O;
                playModel.MS2 = match.MA.FirstOrDefault(x => x.MTID == 1)?.OCA.FirstOrDefault(z => z.N == 3)?.O;
                playModel.IY1MS0 = match.MA.FirstOrDefault(x => x.MTID == 5)?.OCA.FirstOrDefault(z => z.N == 2)?.O;
                playModel.IY2MS0 = match.MA.FirstOrDefault(x => x.MTID == 5)?.OCA.FirstOrDefault(z => z.N == 8)?.O;
                playModel.Score01 = match.MA.FirstOrDefault(x => x.MTID == 205)?.OCA.FirstOrDefault(z => z.N == 1)?.O;
                playModel.Score10 = match.MA.FirstOrDefault(x => x.MTID == 205)?.OCA.FirstOrDefault(z => z.N == 17)?.O;
                playModel.DateTime = Convert.ToDateTime($"{match.D} {match.T}");
                playModel.HasMutualScoring = false;
                playModel.TwoUpGoals = false;
                playModel.HomeUp05 = match.MA.FirstOrDefault(x => x.MTID == 212)?.OCA.FirstOrDefault(z => z.N == 2)?.O;
                playModel.AwayUp05 = match.MA.FirstOrDefault(x => x.MTID == 256)?.OCA.FirstOrDefault(z => z.N == 2)?.O;
                playModel.Up15Ratio = match.MA.FirstOrDefault(x => x.MTID == 11)?.OCA.FirstOrDefault(z => z.N == 2)?.O;
                playModel.Up25Ratio = match.MA.FirstOrDefault(x => x.MTID == 12)?.OCA.FirstOrDefault(z => z.N == 2)?.O;
                playModel.KgRatio = match.MA.FirstOrDefault(x => x.MTID == 38)?.OCA.FirstOrDefault(z => z.N == 1)?.O;

                double fark = 5;

                MutualScoringMatchCalculation(ref isAdded, playModel, ref fark);

                isAdded = MatchWithLotsOfGoalsCalculation(match, isAdded, playModel);

                if (isAdded)
                    playModels.Add(playModel);

            }

            playModels = playModels.Where(x => x.DateTime.Year == DateTime.Now.Year && x.DateTime.Month == DateTime.Now.Month && x.DateTime.Day == DateTime.Now.Day).ToList();

            return playModels;
        }

        /// <summary>
        /// Bültenden gelen response içinde IY0 oynanabilicek maçları hesaplar.
        /// </summary>
        /// <param name="bulletinResponseModel"></param>
        /// <returns></returns>
        public List<Play> FirstHalfDrawMatchs(BulletinResponseModel bulletinResponseModel)
        {
            List<Play> playModels = new List<Play>();

            var firstHalfDrawMatchs = bulletinResponseModel.sg.EA.Where(x => x.TYPE >= 1 && x.MA.Any(z => z.MTID == 1)).ToList();

            foreach (var match in firstHalfDrawMatchs)
            {
                try
                {
                    bool isAdded = false;

                    var index = firstHalfDrawMatchs.IndexOf(match);
                    Play playModel = new Play();

                    playModel.MatchId = match.BRID.ToString();
                    playModel.Team1 = match.HN;
                    playModel.Team2 = match.AN;
                    playModel.ZeroAndOneGoal = match.MA.FirstOrDefault(x => x.MTID == 43)?.OCA.FirstOrDefault(z => z.N == 1)?.O;
                    playModel.FourFiveGoal = match.MA.FirstOrDefault(x => x.MTID == 43)?.OCA.FirstOrDefault(z => z.N == 3)?.O;
                    playModel.MS1 = match.MA.FirstOrDefault(x => x.MTID == 1)?.OCA.FirstOrDefault(z => z.N == 1)?.O;
                    playModel.MS2 = match.MA.FirstOrDefault(x => x.MTID == 1)?.OCA.FirstOrDefault(z => z.N == 3)?.O;
                    playModel.IsIY0MS12 = true;
                    playModel.DateTime = Convert.ToDateTime($"{match.D} {match.T}");

                    var matchCompetitionHistory = NesineComManager.GetMatchCompetitionHistory(match.C.ToString(), true).Result;

                    isAdded = FirstHalfDrawMatchsCalculation(playModel, matchCompetitionHistory);

                    if (isAdded)
                        playModels.Add(playModel);
                }
                catch (Exception)
                {

                }

            }

            playModels = playModels.Where(x => x.DateTime.Year == DateTime.Now.Year && x.DateTime.Month == DateTime.Now.Month && x.DateTime.Day == DateTime.Now.Day).ToList();

            return playModels;
        }


        /// <summary>
        /// Bol gollü geçecek olan maçları hesaplar.
        /// </summary>
        /// <param name="match"></param>
        /// <param name="isAdded"></param>
        /// <param name="playModel"></param>
        /// <returns></returns>
        private bool MatchWithLotsOfGoalsCalculation(EA? match, bool isAdded, Play playModel)
        {
            var oran1 = match.MA.FirstOrDefault(x => x.MTID == 43)?.OCA.FirstOrDefault(z => z.N == 4)?.O;
            var oran2 = match.MA.FirstOrDefault(x => x.MTID == 205)?.OCA.FirstOrDefault(z => z.N == 29)?.O;

            if (oran1 != null && oran2 != null)
            {
                var sonuc = oran1 / oran2;

                if (sonuc > 0.47 && sonuc < 0.49)
                {
                    playModel.Data = sonuc;
                    isAdded = true;
                }
            }

            return isAdded;
        }

        /// <summary>
        /// Karşılıklı gol olma olasılığı olan maçları hesaplar.
        /// </summary>
        /// <param name="isAdded"></param>
        /// <param name="playModel"></param>
        /// <param name="fark"></param>
        private void MutualScoringMatchCalculation(ref bool isAdded, Play playModel, ref double fark)
        {
            if (playModel.ZeroAndOneGoal != null && playModel.FourFiveGoal != null)
                fark = playModel.ZeroAndOneGoal.Value - playModel.FourFiveGoal.Value;

            var msFark = playModel.MS1 - playModel.MS2;

            var scoreFark = playModel.Score10 - playModel.Score01;

            var iymsFark = playModel.IY1MS0 - playModel.IY2MS0;

            if (fark <= 1 && fark >= -1 && iymsFark <= 1 && iymsFark >= -1 && scoreFark <= 1 && scoreFark >= -1)
            {
                if (playModel.IY1MS0.HasValue)
                {
                    isAdded = true;
                }
            }

            if (msFark <= 0.15 && msFark >= -0.25 && (playModel.HomeUp05 == null || playModel.HomeUp05 <= 1.20) && (playModel.AwayUp05 == null || playModel.AwayUp05 <= 1.20))
                isAdded = true;


        }

        /// <summary>
        /// Maçın historysine dayanarak son maçlarda ilk yarısı ne kadar  berabere bitmiş onu hesaplar ve toplam maça göre beraberlik oranı yüksekse true döner.
        /// </summary>
        /// <param name="playModel"></param>
        /// <param name="matchCompetitionHistory"></param>
        /// <returns></returns>
        private bool FirstHalfDrawMatchsCalculation(Play playModel, MatchCompetitionHistory matchCompetitionHistory)
        {
            bool retVal = false;

            if ((playModel.MS1 > 1.35 && playModel.MS1 < 1.65) || (playModel.MS2 > 1.35 && playModel.MS2 < 1.65))
            {
                try
                {
                    if (matchCompetitionHistory.D != null)
                    {
                        var ml = matchCompetitionHistory.D.ML.FirstOrDefault(x => x.TFT == 1);

                        var tt1 = ml.TT.FirstOrDefault(x => x.FT == 1);

                        var tmsFirst = tt1.TMS.First().TA.FirstOrDefault(x => x.AT == 2);

                        var totalFirstHalfResult = tmsFirst.AC + tmsFirst.HC + tmsFirst.DC;

                        var sonuc = (Convert.ToDouble(tmsFirst.DC) / totalFirstHalfResult) * 100;

                        if (sonuc > 60 && totalFirstHalfResult > 4)
                            retVal = true;
                    }

                }
                catch (Exception)
                {
                    retVal = false;
                }

            }

            return retVal;
        }


    }
}
