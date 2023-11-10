using Newtonsoft.Json;

namespace GetBet.Business.NesineCom.Models.ResponseModels
{
    public class NsnBultenName
    {
        [JsonProperty("EID")]
       public int? EID { get; set; }

        [JsonProperty("MID")]
       public int? MID { get; set; }

        [JsonProperty("ON")]
       public int? ON { get; set; }

        [JsonProperty("N")]
        public string N { get; set; }

        [JsonProperty("C")]
       public int? C { get; set; }

        [JsonProperty("AN")]
        public string AN { get; set; }

        [JsonProperty("HN")]
        public string HN { get; set; }
    }
}
