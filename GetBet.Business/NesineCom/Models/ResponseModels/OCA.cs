using Newtonsoft.Json;

namespace GetBet.Business.NesineCom.Models.ResponseModels
{
    public class OCA
    {
        [JsonProperty("N")]
       public int? N { get; set; }

        [JsonProperty("O")]
        public double O { get; set; }

        [JsonProperty("ON")]
        public string ON { get; set; }
    }
}
