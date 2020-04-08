using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Models
{
   public class MatchInfo
    {



        public string match_id { get; set; }
        public int barracks_status_dire { get; set; }
        public int barracks_status_radiant { get; set; }
        public int dire_score { get; set; }
        public int duration { get; set; }

        public int first_blood_time { get; set; }
        public int radiant_score { get; set; }
        public bool radiant_win { get; set; }
        public string start_time { get; set; }
        public int tower_status_dire { get; set; }
        public int tower_status_radiant { get; set; }
        public int skill { get; set; }
        public  Profile profile { get; set; }

    }



}
