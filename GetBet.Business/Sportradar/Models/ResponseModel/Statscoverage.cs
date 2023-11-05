using Newtonsoft.Json;

namespace GetBet.Business.Sportradar.Models.ResponseModel
{
    public class Statscoverage
    {
        [JsonProperty("complexstat")]
        public bool Complexstat { get; set; }

        [JsonProperty("overunder")]
        public bool Overunder { get; set; }

        [JsonProperty("overunderhalftime")]
        public bool Overunderhalftime { get; set; }

        [JsonProperty("fixtures")]
        public bool Fixtures { get; set; }

        [JsonProperty("cuproster")]
        public bool Cuproster { get; set; }

        [JsonProperty("headtohead")]
        public bool Headtohead { get; set; }

        [JsonProperty("lineups")]
        public bool Lineups { get; set; }

        [JsonProperty("topgoals")]
        public bool Topgoals { get; set; }

        [JsonProperty("disciplinary")]
        public bool Disciplinary { get; set; }

        [JsonProperty("redcards")]
        public bool Redcards { get; set; }

        [JsonProperty("yellowcards")]
        public bool Yellowcards { get; set; }

        [JsonProperty("goalminute")]
        public bool Goalminute { get; set; }

        [JsonProperty("goalminscorer")]
        public bool Goalminscorer { get; set; }

        [JsonProperty("substitutions")]
        public bool Substitutions { get; set; }

        [JsonProperty("squadservice")]
        public bool Squadservice { get; set; }

        [JsonProperty("referee")]
        public bool Referee { get; set; }

        [JsonProperty("stadium")]
        public bool Stadium { get; set; }

        [JsonProperty("staffmanagers")]
        public bool Staffmanagers { get; set; }

        [JsonProperty("staffteamofficials")]
        public bool Staffteamofficials { get; set; }

        [JsonProperty("staffassistantcoaches")]
        public bool Staffassistantcoaches { get; set; }

        [JsonProperty("jerseys")]
        public bool Jerseys { get; set; }

        [JsonProperty("goalscorer")]
        public bool Goalscorer { get; set; }

        [JsonProperty("leaguetable")]
        public bool Leaguetable { get; set; }

        [JsonProperty("deepercoverage")]
        public bool Deepercoverage { get; set; }
    }
}
