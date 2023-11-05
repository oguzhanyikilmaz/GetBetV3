using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetBet.Business.Sportradar.Models.ResponseModel
{
    public class Cities
    {
        [JsonProperty("home")]
        public Home Home { get; set; }

        [JsonProperty("away")]
        public Away Away { get; set; }
    }
}
