using Newtonsoft.Json;
using Quiz.Models;
using Quiz.Services;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.ViewModels
{
    class LeaderboardViewModel
    {
        public string Username { get; set; }
        public int Score { get; set; }
        public List<UserScoreList> userScoreList { get; set; }
        Api _api = new Api();
        public async void GetLeaderboardData()
        {
            userScoreList = await _api.GetUserScores();
        }
        
    }
}
