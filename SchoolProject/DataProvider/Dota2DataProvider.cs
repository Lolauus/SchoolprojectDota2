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
        private Rootobject rootobjects;

        public async Task<Rootobject> GetPlayerInfo(string playerId)
        {
            string URL = ($"https://api.opendota.com/api/players/{playerId}");
            Rootobject RootObjects = new Rootobject();
            using (HttpResponseMessage response = await APIHelper.ApiClient.GetAsync(URL))
            {
                if (response.IsSuccessStatusCode)
                {

                    var result = response.Content.ReadAsStringAsync();
                    if (result.Result != null)
                    {
                        var data = JsonConvert.DeserializeObject<Rootobject>(result.Result);
                        RootObjects = data;

                    }
                    else
                    {
                        // hitta ett sätt att presentera datan även om vissa värden är null.
                    }

                }

            }
            return RootObjects;

        }

    }
 }

