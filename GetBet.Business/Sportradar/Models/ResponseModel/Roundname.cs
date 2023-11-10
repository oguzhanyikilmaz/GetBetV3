using Newtonsoft.Json;

namespace GetBet.Business.Sportradar.Models.ResponseModel
{
    public class Roundname
    {
        [JsonProperty("_doc")]
        public string Doc { get; set; }

        [JsonProperty("_id")]
       public int? Id { get; set; }

        [JsonProperty("displaynumber")]
        public object Displaynumber { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("shortname")]
        public string Shortname { get; set; }

        [JsonProperty("cuproundnumber")]
        public object Cuproundnumber { get; set; }

        [JsonProperty("statisticssortorder")]
       public int? Statisticssortorder { get; set; }
    }
}
