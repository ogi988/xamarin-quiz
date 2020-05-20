using Quiz.ViewModels;
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
    public partial class QuizQuestions : ContentPage
    {
        public QuizQuestions()
        {
            InitializeComponent();
            ((QuizQuestionsViewModel)BindingContext).Start();
            NavigationPage.SetHasNavigationBar(this, false);
        }
        protected override bool OnBackButtonPressed()
        {
            //return base.OnBackButtonPressed();
            ((QuizQuestionsViewModel)BindingContext).StopTimer();
            Application.Current.MainPage = new NavigationPage(new Dashboard());
            return true;
        }
    }
}