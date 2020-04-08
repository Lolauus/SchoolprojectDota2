using Newtonsoft.Json;
using SchoolProject.Models;
using SchoolProject.View;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace SchoolProject.DataProvider
{
    class Dota2DataProvider
    {

        public async Task<Rootobject> GetPlayerInfo(string stringInfo)
        {
            string URL = ($"https://api.opendota.com/api/players/{stringInfo}");
            Rootobject Profiles = new Rootobject();
            using (HttpResponseMessage response = await APIHelper.ApiClient.GetAsync(URL))
            {
                if (response.IsSuccessStatusCode)
                {

                    var result = response.Content.ReadAsStringAsync();

                        var data = JsonConvert.DeserializeObject<Rootobject>(result.Result);
                             Profiles = data;

                        if (Profiles.solo_competitive_rank == null || Profiles.competitive_rank == null)
                        {
                            Profiles.solo_competitive_rank = "No Rank";
                            Profiles.competitive_rank = "No Rank";
                        }

                }
            }
            return Profiles;
        }
        public async Task<MatchInfo> GetMatchInfo(string stringInfo)
        {
            string URL = ($"https://api.opendota.com/api/matches/{stringInfo}");
            MatchInfo matchinfo = new MatchInfo();
            using (HttpResponseMessage response = await APIHelper.ApiClient.GetAsync(URL))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = response.Content.ReadAsStringAsync();

                    var data = JsonConvert.DeserializeObject<MatchInfo>(result.Result);
                    matchinfo = data;
                }
            }
            return matchinfo;
        }
    }
 }

