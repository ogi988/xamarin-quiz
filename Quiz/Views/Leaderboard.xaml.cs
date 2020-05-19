using Newtonsoft.Json;
using Quiz.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Quiz.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Leaderboard : ContentPage
    {

       public IList<UserScoreList> userScoreList { get; private set; }

        public Leaderboard()
        {
            InitializeComponent();
            GetLeaderboardData();


            BindingContext = this;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
        public async void  GetLeaderboardData()
        {
            var userScoreList = new List<UserScoreList>();

            var request = new HttpRequestMessage(HttpMethod.Get, Constants.Api + "api/UserScores");
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (senders, cert, chain, sslPolicyErrors) => { return true; };

            HttpClient client = new HttpClient(clientHandler);

            var response = await client.SendAsync(request);
            var content = await response.Content.ReadAsStringAsync();
            userScoreList = JsonConvert.DeserializeObject<List<UserScoreList>>(content);
           
            userScoreListView.ItemsSource = userScoreList.OrderByDescending(x => x.Score);

        }
       
    }
}
