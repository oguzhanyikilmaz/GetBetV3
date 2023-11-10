using Newtonsoft.Json;

namespace GetBet.Business.Sportradar.Models.ResponseModel
{
    public class Birthdate
    {
        [JsonProperty("_doc")]
        public string Doc { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("tz")]
        public string Tz { get; set; }

        [JsonProperty("tzoffset")]
       public int? Tzoffset { get; set; }

        [JsonProperty("uts")]
       public int? Uts { get; set; }
    }
}
