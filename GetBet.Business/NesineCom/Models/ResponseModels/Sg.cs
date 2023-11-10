using Newtonsoft.Json;

namespace GetBet.Business.NesineCom.Models.ResponseModels
{
    public class Sg
    {
        [JsonProperty("eventVersion")]
       public int? eventVersion { get; set; }

        [JsonProperty("marketVersion")]
       public int? marketVersion { get; set; }

        [JsonProperty("oddVersion")]
       public int? oddVersion { get; set; }

        [JsonProperty("drawNo")]
       public int? drawNo { get; set; }

        [JsonProperty("FB")]
       public int? FB { get; set; }

        [JsonProperty("EA")]
        public List<EA> EA { get; set; }

        [JsonProperty("EWMA")]
        public List<EWMA> EWMA { get; set; }

        [JsonProperty("LA")]
        public List<LA> LA { get; set; }
    }
}
