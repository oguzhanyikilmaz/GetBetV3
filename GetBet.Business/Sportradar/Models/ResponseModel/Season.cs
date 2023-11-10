using Newtonsoft.Json;

namespace GetBet.Business.Sportradar.Models.ResponseModel
{
    public class Season
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("_doc")]
        public string Doc { get; set; }

        [JsonProperty("_utid")]
       public int? Utid { get; set; }

        [JsonProperty("_sid")]
       public int? Sid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("abbr")]
        public string Abbr { get; set; }

        [JsonProperty("start")]
        public Start Start { get; set; }

        [JsonProperty("end")]
        public End End { get; set; }

        [JsonProperty("neutralground")]
        public bool Neutralground { get; set; }

        [JsonProperty("friendly")]
        public bool Friendly { get; set; }

        [JsonProperty("currentseasonid")]
       public int? Currentseasonid { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }
    }
}
