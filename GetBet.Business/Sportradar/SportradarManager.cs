using GetBet.Business.NesineCom.Models.ResponseModels;
using GetBet.Business.Sportradar.Models.ResponseModel;
using GetBet.Core.Helpers;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetBet.Business.Sportradar
{
    public class SportradarManager
    {
        readonly RestHelper _restHelper;

        public SportradarManager()
        {
            _restHelper = new RestHelper("https://lmt.fn.sportradar.com/demolmt/tr/Etc:UTC/");
        }

        /// <summary>
        /// Sportradardan maç sonucu verisini getirir.
        /// </summary>
        /// <param name="mathcId"></param>
        /// <returns></returns>
        public async Task<MatchResult> GetMatchResult(string matchId)
        {
            var response = _restHelper.Execute<MatchResult>($"gismo/match_info/{matchId}", Method.Get, null, "GetMatchResult");

            return response;
        }

    }
}
