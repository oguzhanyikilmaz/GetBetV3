using Newtonsoft.Json;

namespace GetBet.Business.NesineCom.Models.ResponseModels
{
    public class EditorVideo
    {
        [JsonProperty("eventId")]
       public int? eventId { get; set; }

        [JsonProperty("videoId")]
        public string videoId { get; set; }
    }
}
