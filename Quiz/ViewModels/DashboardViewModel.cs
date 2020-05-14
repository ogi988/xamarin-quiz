using Quiz.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Quiz.ViewModels
{
    

    class DashboardViewModel
    {
       
        public ICommand ExitCommand
        {
            get
            {
                return new Command( async() =>
                {
                    var action = await Application.Current.MainPage.DisplayAlert("Exit?", "Do you want to logout", "Yes", "No");
                    if (action)
                    {
                        Settings.Settings.AccessToken = "";
                        Settings.Settings.Username = "";
                        Settings.Settings.Password = "";
                        Application.Current.MainPage = new NavigationPage(new Login());
                    }
                    
                    
                });
            }
        }
        public ICommand StartQuizCommand
        {
            get
            {
                return new Command( () =>
                {
                    Application.Current.MainPage = new NavigationPage(new QuizQuestions());
                });
            }
        }
    }
}
