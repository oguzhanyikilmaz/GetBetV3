using GetBet.Business.NesineCom.Models.ResponseModels;
using GetBet.Core.Helpers;
using RestSharp;

namespace GetBet.Business.NesineCom
{
    public class NesineComManager
    {
        readonly RestHelper _restHelper;

        public NesineComManager()
        {
            _restHelper = new RestHelper("https://cdnbulten.nesine.com/api/");
        }

        public async Task<BulletinResponseModel> GetPreBulletinFull()
        {
            var response = _restHelper.Execute<BulletinResponseModel>($"bulten/getprebultenfull", Method.Get, null, "GetPreBulletinFull");

            return response;
        }

    }
}
