using Newtonsoft.Json;
using SchoolProject.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace SchoolProject.DataProvider
{
    class Dota2DataProvider
    {
        public async Task<List<Player>> GetPlayerInfo(string playerId)
        {
            string URL = ($"https://api.opendota.com/api/players/{playerId}");

            List<Player> playerList = new List<Player>();
            Player rootobjects = new Player();
            using (HttpResponseMessage response = await APIHelper.ApiClient.GetAsync(URL))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = response.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<Player>(result.Result);
                }
            }
             return playerList;

        }

        public async Task<List<Matches>> GetMatchInfo(string MatchId)
        {
            string uri = ($"https://api.opendota.com/api/matches/{MatchId}");
            List<Matches> matchlist = new List<Matches>();
            Matches rootobjects = new Matches();
            using (HttpResponseMessage response = await APIHelper.ApiClient.GetAsync(uri))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = response.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<Matches>(result.Result);
                    rootobjects = data;
                    if (rootobjects.Result)
                    {
                        //Textbox som säger att dire vann

                    }
                    else
                    {
                        //textbox som säger att radiant vann
                    }

                }
                
            }
            return matchlist;

        }
    }
}
