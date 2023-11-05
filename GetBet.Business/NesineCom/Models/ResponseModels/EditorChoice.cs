using Newtonsoft.Json;

namespace GetBet.Business.NesineCom.Models.ResponseModels
{
    public class EditorChoice
    {
        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("code")]
        public string code { get; set; }

        [JsonProperty("outcome")]
        public string outcome { get; set; }

        [JsonProperty("marketId")]
        public string marketId { get; set; }
    }
}
