using Newtonsoft.Json;

namespace GetBet.Business.Sportradar.Models.ResponseModel
{
    public class Ft
    {
        [JsonProperty("home")]
        public int Home { get; set; }

        [JsonProperty("away")]
        public int Away { get; set; }
    }
}
