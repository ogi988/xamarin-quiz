using Newtonsoft.Json;
using Quiz.Models;
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
        public async void GetLeaderboardData()
        {
            bool getData = await GetUserScores();
            if (getData)
            {
            
            }
        }
        public async Task<bool> GetUserScores()
        {

            var request = new HttpRequestMessage(HttpMethod.Get, Constants.Api + "api/UserScores");
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (senders, cert, chain, sslPolicyErrors) => { return true; };

            HttpClient client = new HttpClient(clientHandler);

            var response = await client.SendAsync(request);
            var content = await response.Content.ReadAsStringAsync();
            userScoreList = JsonConvert.DeserializeObject<List<UserScoreList>>(content);


            return true;

        }
    }
}
