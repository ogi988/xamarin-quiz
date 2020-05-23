using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Quiz.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Quiz.Settings;

namespace Quiz.Services
{
    class Api
    {
        public async Task<bool> Register(string email, string password, string confirmPassword)
        {
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (senders, cert, chain, sslPolicyErrors) => { return true; };


            HttpClient client = new HttpClient(clientHandler);
            var model = new RegisterBindingModel
            {
                Email = email,
                Password = password,
                ConfirmPassword = confirmPassword

            };
            var json = JsonConvert.SerializeObject(model);
            HttpContent httpContent = new StringContent(json);
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var response = await client.PostAsync(Constants.Api + "api/Account/Register", httpContent);

            return response.IsSuccessStatusCode;
        }
        

        public async Task<string> LoginAsync(string username, string password)
        {
            var keyValues = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("username", username),
                new KeyValuePair<string, string>("password", password),
                new KeyValuePair<string, string>("grant_type", "password")
            };

            var request = new HttpRequestMessage(
                HttpMethod.Post, Constants.Api + "Token");

            request.Content = new FormUrlEncodedContent(keyValues);

            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (senders, cert, chain, sslPolicyErrors) => { return true; };

            HttpClient client = new HttpClient(clientHandler);
            var response = await client.SendAsync(request);

            var content = await response.Content.ReadAsStringAsync();

            JObject jwtDynamic = JsonConvert.DeserializeObject<dynamic>(content);

            var accessTokenExpiration = jwtDynamic.Value<DateTime>(".expires");
            var accessToken = jwtDynamic.Value<string>("access_token");

            Settings.Settings.AccessTokenExpirationDate = accessTokenExpiration;


            return accessToken;
        }
        public async Task<List<QuestionList>> GetQuestions()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, Constants.Api + "api/Questions");
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (senders, cert, chain, sslPolicyErrors) => { return true; };

            HttpClient client = new HttpClient(clientHandler);
            var response = await client.SendAsync(request);
            var content = await response.Content.ReadAsStringAsync();
            var questionLists = JsonConvert.DeserializeObject<List<QuestionList>>(content);
            return questionLists;
        }
        public async Task<bool> InsertUserScore(string username, int score)
        {
            var model = new UserScore
            {
                Username = username,
                Score = score
            };
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (senders, cert, chain, sslPolicyErrors) => { return true; };
            HttpClient client = new HttpClient(clientHandler);
            var json = JsonConvert.SerializeObject(model);
            HttpContent httpContent = new StringContent(json);
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var response = await client.PostAsync(Constants.Api + "api/UserScores", httpContent);
            return response.IsSuccessStatusCode;
        }
        public async Task<List<UserScoreList>> GetUserScores()
        {

            var request = new HttpRequestMessage(HttpMethod.Get, Constants.Api + "api/UserScores");
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (senders, cert, chain, sslPolicyErrors) => { return true; };

            HttpClient client = new HttpClient(clientHandler);

            var response = await client.SendAsync(request);
            var content = await response.Content.ReadAsStringAsync();
            var userScoreList = JsonConvert.DeserializeObject<List<UserScoreList>>(content);
            return userScoreList;
            
        }

    }
}
