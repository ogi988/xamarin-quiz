using Quiz.ViewModels;
using Quiz.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Quiz
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            SetMainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
        public void SetMainPage()
        {
           
           MainPage  = new Register();

           

        }
    }
}
