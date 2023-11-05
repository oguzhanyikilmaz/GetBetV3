using Newtonsoft.Json;

namespace GetBet.Business.Sportradar.Models.ResponseModel
{
    public class Result
    {
        [JsonProperty("home")]
        public int Home { get; set; }

        [JsonProperty("away")]
        public int Away { get; set; }

        [JsonProperty("winner")]
        public string Winner { get; set; }
    }
}
