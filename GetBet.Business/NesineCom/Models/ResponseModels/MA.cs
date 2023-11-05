using Newtonsoft.Json;

namespace GetBet.Business.NesineCom.Models.ResponseModels
{
    public class MA
    {
        [JsonProperty("ID")]
        public int ID { get; set; }

        [JsonProperty("NO")]
        public int NO { get; set; }

        [JsonProperty("MV")]
        public int MV { get; set; }

        [JsonProperty("MTID")]
        public int MTID { get; set; }

        [JsonProperty("MBS")]
        public int MBS { get; set; }

        [JsonProperty("SOV")]
        public double SOV { get; set; }

        [JsonProperty("MS")]
        public int MS { get; set; }

        [JsonProperty("OCA")]
        public List<OCA> OCA { get; set; }

        [JsonProperty("MSD")]
        public object MSD { get; set; }

        [JsonProperty("MED")]
        public object MED { get; set; }

        [JsonProperty("HM")]
        public int? HM { get; set; }

        [JsonProperty("BM")]
        public int? BM { get; set; }

        [JsonProperty("INM")]
        public int? INM { get; set; }
    }
}
