using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetBet.Business.NesineCom.Models.ResponseModels
{
    public class MatchCompetitionHistory
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
    public class ANL
    {
        [JsonProperty("GTID")]
        public int GTID { get; set; }

        [JsonProperty("SID")]
        public int SID { get; set; }

        [JsonProperty("CNT")]
        public int CNT { get; set; }

        [JsonProperty("TTL")]
        public int TTL { get; set; }

        [JsonProperty("P")]
        public double P { get; set; }
    }

    public class AT
    {
        [JsonProperty("TID")]
        public int TID { get; set; }

        [JsonProperty("N")]
        public string N { get; set; }

        [JsonProperty("NS")]
        public string NS { get; set; }

        [JsonProperty("ABR")]
        public string ABR { get; set; }

        [JsonProperty("LID")]
        public int LID { get; set; }

        [JsonProperty("LURL")]
        public string LURL { get; set; }
    }

    public class D
    {
        [JsonProperty("ML")]
        public List<ML> ML { get; set; }
    }

    public class HT
    {
        [JsonProperty("TID")]
        public int TID { get; set; }

        [JsonProperty("N")]
        public string N { get; set; }

        [JsonProperty("NS")]
        public string NS { get; set; }

        [JsonProperty("ABR")]
        public string ABR { get; set; }

        [JsonProperty("LID")]
        public int LID { get; set; }

        [JsonProperty("LURL")]
        public string LURL { get; set; }
    }

    public class LG
    {
        [JsonProperty("TID")]
        public int TID { get; set; }

        [JsonProperty("N")]
        public string N { get; set; }

        [JsonProperty("ABR")]
        public string ABR { get; set; }
    }

    public class ML
    {
        [JsonProperty("TFT")]
        public int TFT { get; set; }

        [JsonProperty("TT")]
        public List<TT> TT { get; set; }

        [JsonProperty("MID")]
        public int MID { get; set; }

        [JsonProperty("BID")]
        public int BID { get; set; }

        [JsonProperty("SID")]
        public int SID { get; set; }

        [JsonProperty("SC")]
        public List<SC> SC { get; set; }

        [JsonProperty("NG")]
        public bool NG { get; set; }

        [JsonProperty("MD")]
        public DateTime MD { get; set; }

        [JsonProperty("FMD")]
        public string FMD { get; set; }

        [JsonProperty("POFMD")]
        public string POFMD { get; set; }

        [JsonProperty("SFMD")]
        public string SFMD { get; set; }

        [JsonProperty("SEA")]
        public string SEA { get; set; }

        [JsonProperty("DFA")]
        public bool DFA { get; set; }

        [JsonProperty("HI")]
        public object HI { get; set; }

        [JsonProperty("HT")]
        public HT HT { get; set; }

        [JsonProperty("AT")]
        public AT AT { get; set; }

        [JsonProperty("LG")]
        public LG LG { get; set; }

        [JsonProperty("RD")]
        public string RD { get; set; }

        [JsonProperty("ODDS")]
        public List<ODD> ODDS { get; set; }

        [JsonProperty("TNS")]
        public object TNS { get; set; }

        [JsonProperty("WID")]
        public int WID { get; set; }

        [JsonProperty("MS")]
        public int MS { get; set; }

        [JsonProperty("BOF")]
        public int BOF { get; set; }

        [JsonProperty("GCE")]
        public bool GCE { get; set; }

        [JsonProperty("DHTN")]
        public List<object> DHTN { get; set; }

        [JsonProperty("DATN")]
        public List<object> DATN { get; set; }
    }

    public class OA
    {
        [JsonProperty("CNT")]
        public int CNT { get; set; }

        [JsonProperty("ANLS")]
        public List<ANL> ANLS { get; set; }

        [JsonProperty("TID")]
        public int TID { get; set; }

        [JsonProperty("N")]
        public string N { get; set; }

        [JsonProperty("NS")]
        public string NS { get; set; }

        [JsonProperty("ABR")]
        public string ABR { get; set; }

        [JsonProperty("LID")]
        public int LID { get; set; }

        [JsonProperty("LURL")]
        public string LURL { get; set; }
    }

    public class ODD
    {
        [JsonProperty("GTID")]
        public int GTID { get; set; }

        [JsonProperty("SID")]
        public int SID { get; set; }

        [JsonProperty("ODD")]
        public string Odd { get; set; }

        [JsonProperty("RST")]
        public int RST { get; set; }
    }


    public class SC
    {
        [JsonProperty("OBI")]
        public int OBI { get; set; }

        [JsonProperty("TY")]
        public int TY { get; set; }

        [JsonProperty("HTS")]
        public int HTS { get; set; }

        [JsonProperty("ATS")]
        public int ATS { get; set; }
    }

    public class TM
    {
        [JsonProperty("ML")]
        public List<ML> ML { get; set; }

        [JsonProperty("TA")]
        public List<Tum> TA { get; set; }

        [JsonProperty("TID")]
        public int TID { get; set; }

        [JsonProperty("N")]
        public string N { get; set; }

        [JsonProperty("NS")]
        public string NS { get; set; }

        [JsonProperty("ABR")]
        public string ABR { get; set; }

        [JsonProperty("LID")]
        public int LID { get; set; }

        [JsonProperty("LURL")]
        public string LURL { get; set; }
    }

    public class TT
    {
        [JsonProperty("FT")]
        public int FT { get; set; }

        [JsonProperty("TMS")]
        public List<TM> TMS { get; set; }

        [JsonProperty("OA")]
        public List<OA> OA { get; set; }
    }

    public class Tum
    {
        [JsonProperty("AT")]
        public int AT { get; set; }

        [JsonProperty("HC")]
        public int HC { get; set; }

        [JsonProperty("AC")]
        public int AC { get; set; }

        [JsonProperty("DC")]
        public int? DC { get; set; }
    }


}
