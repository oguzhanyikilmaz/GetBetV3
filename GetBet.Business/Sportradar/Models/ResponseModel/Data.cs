using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace GetBet.Business.Sportradar.Models.ResponseModel
{
    public class Data
    {
        [JsonProperty("_doc")]
        public string Doc { get; set; }

        [JsonProperty("match")]
        public Match Match { get; set; }

        [JsonProperty("cities")]
        public Cities Cities { get; set; }

        [JsonProperty("stadium")]
        public Stadium Stadium { get; set; }

        [JsonProperty("tournament")]
        public Tournament Tournament { get; set; }

        [JsonProperty("sport")]
        public Sport Sport { get; set; }

        [JsonProperty("realcategory")]
        public Realcategory Realcategory { get; set; }

        [JsonProperty("season")]
        public Season Season { get; set; }

        [JsonProperty("referee")]
        public Referee Referee { get; set; }

        [JsonProperty("manager")]
        public Manager Manager { get; set; }

        [JsonProperty("jerseys")]
        public Jerseys Jerseys { get; set; }

        [JsonProperty("statscoverage")]
        public Statscoverage Statscoverage { get; set; }
    }
}
