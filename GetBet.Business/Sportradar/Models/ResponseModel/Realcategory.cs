using Newtonsoft.Json;

namespace GetBet.Business.Sportradar.Models.ResponseModel
{
    public class Realcategory
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

        [JsonProperty("cc")]
        public Cc Cc { get; set; }
    }

}
