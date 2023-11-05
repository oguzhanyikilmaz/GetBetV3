using Newtonsoft.Json;

namespace GetBet.Business.Sportradar.Models.ResponseModel
{
    public class Hometeam
    {
        [JsonProperty("_doc")]
        public string Doc { get; set; }

        [JsonProperty("_id")]
        public int Id { get; set; }

        [JsonProperty("_sid")]
        public int Sid { get; set; }

        [JsonProperty("_rcid")]
        public int Rcid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("mediumname")]
        public string Mediumname { get; set; }

        [JsonProperty("suffix")]
        public object Suffix { get; set; }

        [JsonProperty("abbr")]
        public string Abbr { get; set; }

        [JsonProperty("nickname")]
        public object Nickname { get; set; }

        [JsonProperty("teamtypeid")]
        public int Teamtypeid { get; set; }

        [JsonProperty("iscountry")]
        public bool Iscountry { get; set; }

        [JsonProperty("sex")]
        public string Sex { get; set; }

        [JsonProperty("haslogo")]
        public bool Haslogo { get; set; }

        [JsonProperty("founded")]
        public string Founded { get; set; }

        [JsonProperty("website")]
        public object Website { get; set; }
    }
}
