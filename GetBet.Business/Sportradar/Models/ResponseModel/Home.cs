using Newtonsoft.Json;

namespace GetBet.Business.Sportradar.Models.ResponseModel
{
    public class Home
    {
        [JsonProperty("_doc")]
        public string Doc { get; set; }

        [JsonProperty("_id")]
       public int? Id { get; set; }

        [JsonProperty("_sid")]
       public int? Sid { get; set; }

        [JsonProperty("uid")]
       public int? Uid { get; set; }

        [JsonProperty("virtual")]
        public bool Virtual { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("mediumname")]
        public string Mediumname { get; set; }

        [JsonProperty("abbr")]
        public string Abbr { get; set; }

        [JsonProperty("nickname")]
        public object Nickname { get; set; }

        [JsonProperty("iscountry")]
        public bool Iscountry { get; set; }

        [JsonProperty("haslogo")]
        public bool Haslogo { get; set; }

        [JsonProperty("homerealcategoryid")]
       public int? Homerealcategoryid { get; set; }

        [JsonProperty("countrycode")]
        public Countrycode Countrycode { get; set; }

        [JsonProperty("yellow_count")]
       public int? YellowCount { get; set; }

        [JsonProperty("red_count")]
       public int? RedCount { get; set; }

        [JsonProperty("birthdate")]
        public Birthdate Birthdate { get; set; }

        [JsonProperty("nationality")]
        public Nationality Nationality { get; set; }

        [JsonProperty("primarypositiontype")]
        public object Primarypositiontype { get; set; }

        [JsonProperty("player")]
        public Player Player { get; set; }

        [JsonProperty("GK")]
        public GK GK { get; set; }
    }
}
