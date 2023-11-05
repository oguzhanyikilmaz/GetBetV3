using Newtonsoft.Json;

namespace GetBet.Business.Sportradar.Models.ResponseModel
{
    public class Player
    {
        [JsonProperty("base")]
        public string Base { get; set; }

        [JsonProperty("sleeve")]
        public string Sleeve { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("split")]
        public string Split { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("sleevelong")]
        public string Sleevelong { get; set; }

        [JsonProperty("real")]
        public bool Real { get; set; }
    }
}
