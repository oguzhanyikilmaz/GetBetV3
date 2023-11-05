using Newtonsoft.Json;

namespace GetBet.Business.Sportradar.Models.ResponseModel
{
    public class Periods
    {
        [JsonProperty("p1")]
        public P1 P1 { get; set; }

        [JsonProperty("ft")]
        public Ft Ft { get; set; }

        [JsonProperty("ot")]
        public Ot Ot { get; set; }
    }
}
