using Newtonsoft.Json;

namespace GetBet.Business.Sportradar.Models.ResponseModel
{
    public class Stadium
    {
        [JsonProperty("_doc")]
        public string Doc { get; set; }

        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("state")]
        public object State { get; set; }

        [JsonProperty("cc")]
        public Cc Cc { get; set; }

        [JsonProperty("capacity")]
        public string Capacity { get; set; }

        [JsonProperty("hometeams")]
        public List<Hometeam> Hometeams { get; set; }

        [JsonProperty("constryear")]
        public string Constryear { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("googlecoords")]
        public string Googlecoords { get; set; }

        [JsonProperty("pitchsize")]
        public Pitchsize Pitchsize { get; set; }
    }
}
