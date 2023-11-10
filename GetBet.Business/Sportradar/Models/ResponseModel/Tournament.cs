using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetBet.Business.Sportradar.Models.ResponseModel
{
    public class Tournament
    {
        [JsonProperty("_doc")]
        public string Doc { get; set; }

        [JsonProperty("_id")]
       public int? Id { get; set; }

        [JsonProperty("_sid")]
       public int? Sid { get; set; }

        [JsonProperty("_rcid")]
       public int? Rcid { get; set; }

        [JsonProperty("_isk")]
       public int? Isk { get; set; }

        [JsonProperty("_tid")]
       public int? Tid { get; set; }

        [JsonProperty("_utid")]
       public int? Utid { get; set; }

        [JsonProperty("_gender")]
        public string Gender { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("abbr")]
        public string Abbr { get; set; }

        [JsonProperty("ground")]
        public object Ground { get; set; }

        [JsonProperty("friendly")]
        public bool Friendly { get; set; }

        [JsonProperty("seasonid")]
       public int? Seasonid { get; set; }

        [JsonProperty("currentseason")]
       public int? Currentseason { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("seasontype")]
        public string Seasontype { get; set; }

        [JsonProperty("seasontypename")]
        public string Seasontypename { get; set; }

        [JsonProperty("seasontypeunique")]
        public string Seasontypeunique { get; set; }

        [JsonProperty("livetable")]
        public bool Livetable { get; set; }

        [JsonProperty("cuprosterid")]
        public string Cuprosterid { get; set; }

        [JsonProperty("roundbyround")]
        public bool Roundbyround { get; set; }

        [JsonProperty("tournamentlevelorder")]
       public int? Tournamentlevelorder { get; set; }

        [JsonProperty("tournamentlevelname")]
        public string Tournamentlevelname { get; set; }

        [JsonProperty("outdated")]
        public bool Outdated { get; set; }
    }
}
