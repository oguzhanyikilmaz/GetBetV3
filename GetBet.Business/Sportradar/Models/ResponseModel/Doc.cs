using Newtonsoft.Json;

namespace GetBet.Business.Sportradar.Models.ResponseModel
{
    public class Doc
    {
        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("_dob")]
        public int Dob { get; set; }

        [JsonProperty("_maxage")]
        public int Maxage { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }
    }
}
