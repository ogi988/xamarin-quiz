using Newtonsoft.Json;
using Quiz.Models;
using Quiz.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
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
            Api _api = new Api();
            var userScoreList = new List<UserScoreList>();

            userScoreList = await _api.GetUserScores();
           
            userScoreListView.ItemsSource = userScoreList.OrderByDescending(x => x.Score);

        }
       
    }
}
