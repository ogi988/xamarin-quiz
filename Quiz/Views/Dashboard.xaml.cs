using Android.OS;
using Android.Provider;
using Newtonsoft.Json;
using Quiz.Models;
using Quiz.ViewModels;
using Quiz.Views;
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

        private  void startQuiz(object sender, EventArgs e)
        {
            Navigation.PushAsync(new QuizQuestions());
            
        }
        private void GoToLeaderboard(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Leaderboard());
        }
    }
}