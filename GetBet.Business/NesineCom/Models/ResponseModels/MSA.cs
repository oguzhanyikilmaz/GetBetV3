using Newtonsoft.Json;

namespace GetBet.Business.NesineCom.Models.ResponseModels
{
    public class MSA
    {
        [JsonProperty("ID")]
       public int? ID { get; set; }

        [JsonProperty("NO")]
       public int? NO { get; set; }

        [JsonProperty("MN")]
        public string MN { get; set; }

        [JsonProperty("MV")]
       public int? MV { get; set; }

        [JsonProperty("MT")]
       public int? MT { get; set; }

        [JsonProperty("MBS")]
       public int? MBS { get; set; }

        [JsonProperty("SOV")]
        public double SOV { get; set; }

        [JsonProperty("MS")]
       public int? MS { get; set; }

        [JsonProperty("MSD")]
        public object MSD { get; set; }

        [JsonProperty("MED")]
        public object MED { get; set; }

        [JsonProperty("OCA")]
        public List<OCA> OCA { get; set; }

        [JsonProperty("D")]
        public string D { get; set; }

        [JsonProperty("T")]
        public string T { get; set; }

        [JsonProperty("IO")]
        public string IO { get; set; }

        [JsonProperty("VT")]
       public int? VT { get; set; }
    }
}
