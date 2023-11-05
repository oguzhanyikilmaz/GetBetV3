using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetBet.Business.Sportradar.Models.ResponseModel
{
    public class Coverage
    {
        [JsonProperty("lineup")]
        public int Lineup { get; set; }

        [JsonProperty("formations")]
        public int Formations { get; set; }

        [JsonProperty("livetable")]
        public int Livetable { get; set; }

        [JsonProperty("injuries")]
        public int Injuries { get; set; }

        [JsonProperty("ballspotting")]
        public bool Ballspotting { get; set; }

        [JsonProperty("cornersonly")]
        public bool Cornersonly { get; set; }

        [JsonProperty("multicast")]
        public bool Multicast { get; set; }

        [JsonProperty("scoutmatch")]
        public int Scoutmatch { get; set; }

        [JsonProperty("scoutcoveragestatus")]
        public int Scoutcoveragestatus { get; set; }

        [JsonProperty("scoutconnected")]
        public bool Scoutconnected { get; set; }

        [JsonProperty("liveodds")]
        public bool Liveodds { get; set; }

        [JsonProperty("deepercoverage")]
        public bool Deepercoverage { get; set; }

        [JsonProperty("tacticallineup")]
        public bool Tacticallineup { get; set; }

        [JsonProperty("basiclineup")]
        public bool Basiclineup { get; set; }

        [JsonProperty("hasstats")]
        public bool Hasstats { get; set; }

        [JsonProperty("inlivescore")]
        public bool Inlivescore { get; set; }

        [JsonProperty("advantage")]
        public object Advantage { get; set; }

        [JsonProperty("tiebreak")]
        public object Tiebreak { get; set; }

        [JsonProperty("paperscorecard")]
        public object Paperscorecard { get; set; }

        [JsonProperty("penaltyshootout")]
        public int Penaltyshootout { get; set; }

        [JsonProperty("scouttest")]
        public bool Scouttest { get; set; }

        [JsonProperty("lmtsupport")]
        public int Lmtsupport { get; set; }

        [JsonProperty("venue")]
        public bool Venue { get; set; }

        [JsonProperty("matchdatacomplete")]
        public bool Matchdatacomplete { get; set; }

        [JsonProperty("mediacoverage")]
        public bool Mediacoverage { get; set; }

        [JsonProperty("substitutions")]
        public bool Substitutions { get; set; }
    }
}
