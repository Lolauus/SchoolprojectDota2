using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Models
{
    public class Rootobject
    {
        public string solo_competitive_rank { get; set; }
        public int rank_tier { get; set; }
        public Profile profile { get; set; }
        public MatchInfo matchInfo { get; set; }
        public string competitive_rank { get; set; }
        public MmrEstimate mmr_estimate { get; set; }
    }
}


//PlayerUserName.Text = rootobject.profile.personaname;
//PlayerSteamId.Text = ($"Steam Profile: {rootobject.profile.profileurl}");
//PlayerAccountId.Text = ($"Your Account ID: {rootobject.profile.account_id}");
//PlayerRank.Text = ($"Team MMR: {rootobject.competitive_rank}\n") + ($" Solo MMR: {rootobject.solo_competitive_rank}");
//PlayerMatchesPlayed.Text = ($"Estimated Rating: {rootobject.mmr_estimate.estimate.ToString()}");
//PlayerAvatar.Source = img.Source;