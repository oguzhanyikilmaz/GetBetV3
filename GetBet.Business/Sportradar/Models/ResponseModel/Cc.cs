using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetBet.Business.Sportradar.Models.ResponseModel
{
    public class Cc
    {
        [JsonProperty("_doc")]
        public string Doc { get; set; }

        [JsonProperty("_id")]
        public int Id { get; set; }

        [JsonProperty("a2")]
        public string A2 { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("a3")]
        public string A3 { get; set; }

        [JsonProperty("ioc")]
        public string Ioc { get; set; }

        [JsonProperty("continentid")]
        public int Continentid { get; set; }

        [JsonProperty("continent")]
        public string Continent { get; set; }

        [JsonProperty("population")]
        public int Population { get; set; }
    }
}
