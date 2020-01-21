using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Models
{
    public class Rootobject
    {
        public string tracked_until { get; set; }
        public int solo_competitive_rank { get; set; }
        public int rank_tier { get; set; }
        public Profile profile { get; set; }
        public int competitive_rank { get; set; }
        public object leaderboard_rank { get; set; }
        public MmrEstimate mmr_estimate { get; set; }
    }
}
