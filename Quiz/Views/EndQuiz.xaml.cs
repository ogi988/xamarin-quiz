using Quiz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Quiz.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EndQuiz : ContentPage
    {
        public EndQuiz(int Score)
        {            
            InitializeComponent();
            score.Text = Score.ToString();
        }

        private void TryAgain(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new QuizQuestions());
        }

        private void GoBackToDashboard(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Dashboard());

        }
    }
}