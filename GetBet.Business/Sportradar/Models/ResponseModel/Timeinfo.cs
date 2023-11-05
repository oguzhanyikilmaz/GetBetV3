using Newtonsoft.Json;

namespace GetBet.Business.Sportradar.Models.ResponseModel
{
    public class Timeinfo
    {
        [JsonProperty("injurytime")]
        public object Injurytime { get; set; }

        [JsonProperty("ended")]
        public string Ended { get; set; }

        [JsonProperty("started")]
        public object Started { get; set; }

        [JsonProperty("played")]
        public object Played { get; set; }

        [JsonProperty("remaining")]
        public object Remaining { get; set; }

        [JsonProperty("running")]
        public bool Running { get; set; }
    }
}
