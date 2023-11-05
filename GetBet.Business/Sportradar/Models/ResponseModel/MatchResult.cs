using Newtonsoft.Json;

namespace GetBet.Business.Sportradar.Models.ResponseModel
{
    public class MatchResult
    {
        [JsonProperty("queryUrl")]
        public string QueryUrl { get; set; }

        [JsonProperty("doc")]
        public List<Doc> Doc { get; set; }
    }
}
