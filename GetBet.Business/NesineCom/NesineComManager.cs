using GetBet.Business.NesineCom.Models.ResponseModels;
using GetBet.Core.Helpers;
using RestSharp;

namespace GetBet.Business.NesineCom
{
    public class NesineComManager
    {
        private RestHelper _restHelper;

        public NesineComManager()
        {
            _restHelper = new RestHelper("https://cdnbulten.nesine.com/api/");
        }

        public async Task<BulletinResponseModel> GetPreBulletinFull()
        {
            var response = _restHelper.Execute<BulletinResponseModel>($"bulten/getprebultenfull", Method.Get, null, "GetPreBulletinFull");

            return await Task.FromResult(response);
        }

        public async Task<MatchCompetitionHistory> GetMatchCompetitionHistory(string matchId, bool isApiStats)
        {
            _restHelper = new RestHelper("https://apistats.nesine.com/api/");

            var response = _restHelper.Execute<MatchCompetitionHistory>($"v3/HeadToHead/{matchId}/CompetitionHistory", Method.Get, null, "GetMatchCompetitionHistory");

            return await Task.FromResult(response);
        }

        public async Task<LastMatchesModel> GetMatchLastMatches(string matchId)
        {
            _restHelper = new RestHelper("https://apistats.nesine.com/api/");

            var response = _restHelper.Execute<LastMatchesModel>($"v3/HeadToHead/{matchId}/LastMatches", Method.Get, null, "GetMatchLastMatches");

            return await Task.FromResult(response);
        }
    }
}
