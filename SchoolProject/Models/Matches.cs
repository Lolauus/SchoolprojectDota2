using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Models
{
    class Matches
    {
        [JsonProperty("match_id")]
        public string Id { get; set; }
        [JsonProperty("hero_id")]
        public string[] Heros { get; set; }
        [JsonProperty("players")]
        public string UserName { get; set; }
        [JsonProperty("radiant_win")]
        public Boolean Result { get; set; }
        public string Duration { get; set; }

    }
}
