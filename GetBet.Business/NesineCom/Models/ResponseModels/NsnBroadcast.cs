using Newtonsoft.Json;

namespace GetBet.Business.NesineCom.Models.ResponseModels
{
    public class NsnBroadcast
    {
        [JsonProperty("E")]
        public int E { get; set; }

        [JsonProperty("M")]
        public int M { get; set; }

        [JsonProperty("C")]
        public string C { get; set; }
    }
}
