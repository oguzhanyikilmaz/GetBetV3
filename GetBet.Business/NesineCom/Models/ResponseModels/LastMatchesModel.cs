using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetBet.Business.NesineCom.Models.ResponseModels
{
    public class LastMatchesModel
    {
        [JsonProperty("sc")]
        public int Sc { get; set; }

        [JsonProperty("d")]
        public D D { get; set; }

        [JsonProperty("el")]
        public object El { get; set; }

        [JsonProperty("ml")]
        public object Ml { get; set; }
    }

    public class HI
    {
        [JsonProperty("T")]
        public int T { get; set; }

        [JsonProperty("TM")]
        public int TM { get; set; }

        [JsonProperty("IT")]
        public int IT { get; set; }

        [JsonProperty("TT")]
        public int TT { get; set; }

        [JsonProperty("FT")]
        public string FT { get; set; }

        [JsonProperty("PN")]
        public string PN { get; set; }

        [JsonProperty("TD")]
        public object TD { get; set; }
    }

}
