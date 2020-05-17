using Android.OS;
using Android.Provider;
using Newtonsoft.Json;
using Quiz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Quiz
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Dashboard : ContentPage
    {
        public Dashboard()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void startQuiz(object sender, EventArgs e)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "https://10.0.2.2:44348/api/Questions");
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (senders, cert, chain, sslPolicyErrors) => { return true; };

            HttpClient client = new HttpClient(clientHandler);
            var response = await client.SendAsync(request);
            var content = await response.Content.ReadAsStringAsync();
            var model = JsonConvert.DeserializeObject<List<QuestionList>>(content);
            
            Random rnd = new Random();
            if (response.IsSuccessStatusCode)
            {
                await DisplayAlert("Alert", "Kviz pocinje", "OK");
            }
        }
    }
}