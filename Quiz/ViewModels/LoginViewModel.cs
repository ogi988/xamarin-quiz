using Quiz.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Quiz.Settings;
namespace Quiz.ViewModels
{
    public class LoginViewModel
    {
        private readonly Api _api = new Api();
        QuizQuestionsViewModel QuizViewModel = new QuizQuestionsViewModel();
        public string Username { get; set; }
        public string Password { get; set; }
        public ICommand LoginCommand
        {
            get
            {
                return new Command(async () =>
                {
                    var accesstoken = await _api.LoginAsync(Username, Password);
                    if (accesstoken != null)
                    {
                        Settings.Settings.Username = Username;
                        Settings.Settings.Password = Password;

                        Settings.Settings.AccessToken = accesstoken;
                        Application.Current.MainPage = new NavigationPage(new Dashboard());
                    }
                    else
                    {
                        await Application.Current.MainPage.DisplayAlert("Error", "Wrong username or password", "Ok");
                    }

                });
            }
        }

        public LoginViewModel()
        {
            Username = Settings.Settings.Username;
            Password = Settings.Settings.Password;
        }
    }
}
