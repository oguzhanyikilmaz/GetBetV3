using Newtonsoft.Json;
using RestSharp;
using System.Net;

namespace GetBet.Core.Helpers
{
    public class RestHelper
    {
        private string baseurl = "";

        public RestHelper(string baseurl)
        {
            this.baseurl = baseurl;
        }

        public T Execute<T>(string query, Method method, object model, string errorMethod) where T : new()
        {

            RestClient client = new RestClient(baseurl);
            var request = new RestRequest(query, method);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("User-Agent", CHelper.GetRandomUserAgent());
            //request.AddHeader("Authorization", $"Bearer {GetAuthToken()}");

            string json = JsonConvert.SerializeObject(model);


            if (model != null)
            {

                request.RequestFormat = DataFormat.Json;
                request.AddParameter("application/json", json, ParameterType.RequestBody);
            }

            var response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.Unauthorized || response.StatusCode == HttpStatusCode.ServiceUnavailable || response.StatusCode == HttpStatusCode.InternalServerError || response.StatusCode.ToString() == "0" || response.StatusCode == HttpStatusCode.Forbidden)
            {
                //GetAuthToken();
                Execute<T>(query, method, model, errorMethod);
            }

            if (response.StatusCode == HttpStatusCode.UnprocessableEntity)
                return default;

            if (response.StatusCode == HttpStatusCode.Accepted || response.StatusCode == HttpStatusCode.OK)
            {
                try
                {
                    T result = JsonConvert.DeserializeObject<T>(response.Content);

                    return result;
                }
                catch (Exception ex)
                {
                    throw new Exception($"Something went wrong inside the Execute method:{method} errorMethod:{errorMethod} response : {response.Content}", ex);

                }
            }
            else
            {
                throw new Exception($"Something went wrong inside the Execute method:{method} errorMethod:{errorMethod} response : {response.Content}");
            }
        }

    }
}
