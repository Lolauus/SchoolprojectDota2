using SchoolProject.DataProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Models
{
    class Session
    {

        private static Rootobject _EmployeeData;
        public static Rootobject EmployeeData
        {
            get
            {
                return _EmployeeData;

            }
        }

        private static MatchInfo _Matchinfon;
        public static MatchInfo Matchinfon
        {
            get
            {
                return _Matchinfon;
                
            }
        }
        public static async Task<bool> MatchInfo(string CardID)
        {
            Dota2DataProvider dpv = new Dota2DataProvider();

            _Matchinfon = await dpv.GetMatchInfo(CardID);

            var newduration = Matchinfon.duration / 60;

            Matchinfon.duration = newduration;

            //TODO: ADD || CardID == "" to first If-statement so that the value cannot be empty.

            if (Matchinfon == null)
            {
                return false;

            }
            else return true;
        }

        public static async Task<bool> PlayerInfo(string CardID)
        {
            Dota2DataProvider dpv = new Dota2DataProvider();

            _EmployeeData = await dpv.GetPlayerInfo(CardID);

            //TODO: ADD || CardID == "" to first If-statement so that the value cannot be empty.

            if (EmployeeData == null)
            {
                return false;

            }
            else return true;
        }
    }
}
