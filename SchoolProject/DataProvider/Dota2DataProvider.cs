using Newtonsoft.Json;
using SchoolProject.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

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
                    var data = JsonConvert.DeserializeObject<Rootobject>(result.Result);
                    RootObjects = data;
                   await GetWinRatio(playerId);
                }
            }
            return RootObjects;

        }

        public async Task<Rootobject> GetWinRatio(string playerId)
        {

            string WlUrl = ($"https://api.opendota.com/api/players/{playerId}/wl");
            Rootobject RootObjects = new Rootobject();
            using (HttpResponseMessage response = await APIHelper.ApiClient.GetAsync(WlUrl))
            {
                if (response.IsSuccessStatusCode)
                {
                    await APIHelper.ApiClient.GetAsync(WlUrl);
                    var result = response.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<Rootobject>(result.Result);
                    RootObjects = data;
                }
            }
            return RootObjects;

        }
    }
 }

