using Quiz.Services;
using Quiz.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Quiz.ViewModels
{
    class RegisterViewModel
    {
        private readonly Api _api = new Api();
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public ICommand RegisterCommand
        {
            get
            {
                return new Command(async () =>
                {
                    var isRegistered = await _api.Register
                        (Username, Password, ConfirmPassword);


                    if (isRegistered)
                    {
                        
                        await Application.Current.MainPage.DisplayAlert("Success", "Account registred", "Ok");
                    

                    }
                    else
                    {
                        await Application.Current.MainPage.DisplayAlert("Error", "Something went wrong, try again", "Ok");
                    }
                });
            }
        }
    }
}
