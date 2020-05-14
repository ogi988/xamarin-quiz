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
           
            var login = new Login();
            var register = new Register();
            var dashboard = new Dashboard();

            if (!string.IsNullOrEmpty(Settings.Settings.AccessToken))
            {
                if (Settings.Settings.AccessTokenExpirationDate < DateTime.UtcNow.AddHours(1))
                {
                    var loginViewModel = new LoginViewModel();
                    loginViewModel.LoginCommand.Execute(null);
                }
                MainPage = new NavigationPage(dashboard);
                NavigationPage.SetHasNavigationBar(dashboard, false);
            }
            else if (!string.IsNullOrEmpty(Settings.Settings.Username)
                  && !string.IsNullOrEmpty(Settings.Settings.Password))
            {
                MainPage = new NavigationPage(login);
                NavigationPage.SetHasNavigationBar(login, false);
            }
            else
            {
                MainPage = new NavigationPage(register);
                NavigationPage.SetHasNavigationBar(register, false);
            }

        }
    }
}
