using Newtonsoft.Json;

namespace GetBet.Business.Sportradar.Models.ResponseModel
{
    public class Teams
    {
        [JsonProperty("home")]
        public Home Home { get; set; }

        [JsonProperty("away")]
        public Away Away { get; set; }
    }
}
