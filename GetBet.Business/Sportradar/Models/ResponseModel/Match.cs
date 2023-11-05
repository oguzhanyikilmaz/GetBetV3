using GetBet.Core.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetBet.Business.Sportradar.Models.ResponseModel
{
    public class Match
    {
        [JsonProperty("_doc")]
        public string Doc { get; set; }

        [JsonProperty("_id")]
        public int Id { get; set; }

        [JsonProperty("_sid")]
        public int Sid { get; set; }

        [JsonProperty("_seasonid")]
        public int Seasonid { get; set; }

        [JsonProperty("_rcid")]
        public int Rcid { get; set; }

        [JsonProperty("_tid")]
        public int Tid { get; set; }

        [JsonProperty("_utid")]
        public int Utid { get; set; }

        [JsonProperty("_dt")]
        public Dt Dt { get; set; }

        [JsonProperty("round")]
        public int Round { get; set; }

        [JsonProperty("roundname")]
        public Roundname Roundname { get; set; }

        [JsonProperty("cuproundmatchnumber")]
        public int Cuproundmatchnumber { get; set; }

        [JsonProperty("cuproundnumberofmatches")]
        public int Cuproundnumberofmatches { get; set; }

        [JsonProperty("week")]
        public int Week { get; set; }

        [JsonProperty("coverage")]
        public Coverage Coverage { get; set; }

        [JsonProperty("result")]
        public Result Result { get; set; }

        [JsonProperty("periods")]
        public Periods Periods { get; set; }

        [JsonProperty("updated_uts")]
        public int UpdatedUts { get; set; }

        [JsonProperty("ended_uts")]
        public int EndedUts { get; set; }

        [JsonProperty("p")]
        public string P { get; set; }

        [JsonProperty("ptime")]
        public int Ptime { get; set; }

        [JsonProperty("timeinfo")]
        public Timeinfo Timeinfo { get; set; }

        [JsonProperty("teams")]
        public Teams Teams { get; set; }

        [JsonProperty("status")]
        public Status Status { get; set; }

        [JsonProperty("removed")]
        public bool Removed { get; set; }

        [JsonProperty("facts")]
        public bool Facts { get; set; }

        [JsonProperty("stadiumid")]
        public int Stadiumid { get; set; }

        [JsonProperty("localderby")]
        public bool Localderby { get; set; }

        [JsonProperty("distance")]
        public int Distance { get; set; }

        [JsonProperty("weather")]
        public object Weather { get; set; }

        [JsonProperty("pitchcondition")]
        public object Pitchcondition { get; set; }

        [JsonProperty("temperature")]
        public object Temperature { get; set; }

        [JsonProperty("wind")]
        public object Wind { get; set; }

        [JsonProperty("windadvantage")]
        public int Windadvantage { get; set; }

        [JsonProperty("matchstatus")]
        public string Matchstatus { get; set; }

        [JsonProperty("postponed")]
        public bool Postponed { get; set; }

        [JsonProperty("cancelled")]
        public bool Cancelled { get; set; }

        [JsonProperty("walkover")]
        public bool Walkover { get; set; }

        [JsonProperty("hf")]
        public double Hf { get; set; }

        [JsonProperty("periodlength")]
        public int Periodlength { get; set; }

        [JsonProperty("numberofperiods")]
        public int Numberofperiods { get; set; }

        [JsonProperty("overtimelength")]
        public int Overtimelength { get; set; }

        [JsonProperty("tobeannounced")]
        public bool Tobeannounced { get; set; }

        [JsonProperty("cards")]
        public Cards Cards { get; set; }
    }
}
