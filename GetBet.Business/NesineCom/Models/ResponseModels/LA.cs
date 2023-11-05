using Newtonsoft.Json;

namespace GetBet.Business.NesineCom.Models.ResponseModels
{
    public class LA
    {
        [JsonProperty("LID")]
        public int LID { get; set; }

        [JsonProperty("N")]
        public string N { get; set; }

        [JsonProperty("CC")]
        public string CC { get; set; }

        [JsonProperty("SO")]
        public int SO { get; set; }
    }
}
