using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Models
{
    class Player
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("personaname")]
        public string UserName { get; set; }
        public string Record { get; set; }
        public int MatchesPlayed { get; set; }

    }
}
