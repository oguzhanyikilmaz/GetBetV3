using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetBet.Entities.Concrete
{
    public class IY0StatsModel:BaseModel
    {
        public int TotalPlay { get; set; }
        public int IY0Play { get; set; }
        public int LosePlay { get; set; }
        public DateTime CreateDate { get; set; }
        public double SuccessRatio { get; set; }
    }
}
