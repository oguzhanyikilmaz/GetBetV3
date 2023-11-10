using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetBet.Business.Models
{
    public class StatsModel
    {
        public int TotalPlay { get; set; }
        public int TwoUpGoalsPlay { get; set; }
        public int HasMutualScoringPlay { get; set; }
        public int LosePlay { get; set; }
    }
}
