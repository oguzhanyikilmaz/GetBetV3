using Newtonsoft.Json;

namespace GetBet.Business.Sportradar.Models.ResponseModel
{
    public class Status
    {
        [JsonProperty("_doc")]
        public string Doc { get; set; }

        [JsonProperty("_id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
