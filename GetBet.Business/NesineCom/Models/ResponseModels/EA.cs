using Newtonsoft.Json;

namespace GetBet.Business.NesineCom.Models.ResponseModels
{
    public class EA
    {
        [JsonProperty("C")]
        public int C { get; set; }

        [JsonProperty("EV")]
        public int EV { get; set; }

        [JsonProperty("ENN")]
        public string ENN { get; set; }

        [JsonProperty("TYPE")]
        public int TYPE { get; set; }

        [JsonProperty("GT")]
        public int GT { get; set; }

        [JsonProperty("D")]
        public string D { get; set; }

        [JsonProperty("ESD")]
        public object ESD { get; set; }

        [JsonProperty("ED")]
        public object ED { get; set; }

        [JsonProperty("DAY")]
        public string DAY { get; set; }

        [JsonProperty("T")]
        public string T { get; set; }

        [JsonProperty("P")]
        public int P { get; set; }

        [JsonProperty("LC")]
        public int LC { get; set; }

        [JsonProperty("BC")]
        public string BC { get; set; }

        [JsonProperty("LE")]
        public int LE { get; set; }

        [JsonProperty("BP")]
        public int BP { get; set; }

        [JsonProperty("BS")]
        public int BS { get; set; }

        [JsonProperty("NS")]
        public int NS { get; set; }

        [JsonProperty("MA")]
        public List<MA> MA { get; set; }

        [JsonProperty("MSA")]
        public List<MSA> MSA { get; set; }

        [JsonProperty("CE")]
        public int CE { get; set; }

        [JsonProperty("BRID")]
        public int BRID { get; set; }

        [JsonProperty("HN")]
        public string HN { get; set; }

        [JsonProperty("AN")]
        public string AN { get; set; }
    }
}
