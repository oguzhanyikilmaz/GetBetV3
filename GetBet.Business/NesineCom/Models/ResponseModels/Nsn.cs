using Newtonsoft.Json;

namespace GetBet.Business.NesineCom.Models.ResponseModels
{
    public class Nsn
    {
        [JsonProperty("nsnDataVersion")]
        public string nsnDataVersion { get; set; }

        [JsonProperty("percentages")]
        public List<object> percentages { get; set; }

        [JsonProperty("outcomePercentages")]
        public OutcomePercentages outcomePercentages { get; set; }

        [JsonProperty("nsnBultenNames")]
        public List<NsnBultenName> nsnBultenNames { get; set; }

        [JsonProperty("nsnBroadcasts")]
        public List<NsnBroadcast> nsnBroadcasts { get; set; }

        [JsonProperty("editorChoices")]
        public List<EditorChoice> editorChoices { get; set; }

        [JsonProperty("editorVideos")]
        public List<EditorVideo> editorVideos { get; set; }

        [JsonProperty("editors")]
        public Editors editors { get; set; }

        [JsonProperty("editorComments")]
        public List<int> editorComments { get; set; }

        [JsonProperty("bestWinnersBets")]
        public BestWinnersBets bestWinnersBets { get; set; }
    }
}
