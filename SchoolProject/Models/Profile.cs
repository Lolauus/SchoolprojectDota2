using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Models
{
    public class Profile
    {
        public int account_id { get; set; }
        public string personaname { get; set; }
        public object name { get; set; }
        public bool plus { get; set; }
        public int cheese { get; set; }
        public string steamid { get; set; }
        public string profileurl { get; set; }
        public DateTime last_login { get; set; }
        public string loccountrycode { get; set; }
        public bool is_contributor { get; set; }
    }
}
