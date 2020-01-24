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
        public async Task<Rootobject> GetPlayerInfo(string playerId)
        {
            string URL = ($"https://api.opendota.com/api/players/{playerId}");
            Rootobject rootobjects = new Rootobject();
            using (HttpResponseMessage response = await APIHelper.ApiClient.GetAsync(URL))
            {
                if (response.IsSuccessStatusCode)
                {

                    var result = response.Content.ReadAsStringAsync();

                        var data = JsonConvert.DeserializeObject<Rootobject>(result.Result);
                        rootobjects = data;

                    if (rootobjects.solo_competitive_rank == null || rootobjects.competitive_rank == null)
                    {
                        rootobjects.solo_competitive_rank = "No Rank";
                        rootobjects.competitive_rank = "No Rank";

                    }


                }

            }
            return rootobjects;

        }

    }
 }

