using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Quiz.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;


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
        

        
    }
}
