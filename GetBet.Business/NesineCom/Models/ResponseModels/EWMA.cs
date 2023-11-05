using Newtonsoft.Json;

namespace GetBet.Business.NesineCom.Models.ResponseModels
{
    public class EWMA
    {
        [JsonProperty("C")]
        public int C { get; set; }

        [JsonProperty("TYPE")]
        public int TYPE { get; set; }

        [JsonProperty("D")]
        public string D { get; set; }

        [JsonProperty("ESD")]
        public object ESD { get; set; }

        [JsonProperty("HN")]
        public string HN { get; set; }

        [JsonProperty("AN")]
        public string AN { get; set; }

        [JsonProperty("LC")]
        public string LC { get; set; }

        [JsonProperty("LN")]
        public string LN { get; set; }

        [JsonProperty("LO")]
        public int LO { get; set; }

        [JsonProperty("ENO")]
        public string ENO { get; set; }
    }
}
