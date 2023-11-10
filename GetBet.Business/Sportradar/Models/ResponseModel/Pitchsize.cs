using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetBet.Business.Sportradar.Models.ResponseModel
{
    public class Pitchsize
    {
        [JsonProperty("x")]
       public int? X { get; set; }

        [JsonProperty("y")]
       public int? Y { get; set; }
    }
}
