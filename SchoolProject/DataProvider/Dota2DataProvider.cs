using Newtonsoft.Json;
using SchoolProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace SchoolProject.DataProvider
{
    class Dota2DataProvider
    {
        public async Task<List<Player>> GetPlayerInfo(string playerId)
        {
            string URL = ($"https://api.opendota.com/api/players/{playerId}");
            List<Player> playerList = new List<Player>();
            using (HttpResponseMessage response = await APIHelper.ApiClient.GetAsync(URL))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = response.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<Player>(result.Result);
                    foreach (var name in data.UserName)
                    {
                        //playerList.Add(name);
                    }

                }
                return playerList;
            }

        }

        public async Task<List<Matches>> GetMatchInfo(string MatchId)
        {
            string uri = ($"https://api.opendota.com/api/matches/{MatchId}");
            List<Matches> Matchlist = new List<Matches>();
            using (HttpResponseMessage response = await APIHelper.ApiClient.GetAsync(uri))
            {

                if (response.IsSuccessStatusCode)
                {
                    var result = response.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<Matches>(result.Result);
                    //foreach (var match in data.UserName)
                    //{
                    //    match. = HttpUtility.HtmlDecode(question.TheQuestion);
                    //    question.CorrectAnswer = HttpUtility.HtmlDecode(question.CorrectAnswer);
                    //    for (int i = 0; i < question.IncorrectAnswers.Count; i++)
                    //    {
                    //        question.IncorrectAnswers[i] = HttpUtility.HtmlDecode(question.IncorrectAnswers[i]);
                    //    }
                    //    Matchlist.Add(match);
                    //}
                }
            }
            return Matchlist;

        }
    }
}
