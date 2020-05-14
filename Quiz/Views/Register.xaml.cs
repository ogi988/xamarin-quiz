using Android.Content;
using Newtonsoft.Json;
using Quiz.Models;
using Quiz.Views;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Quiz
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Register : ContentPage
    {
        public Register()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            lblLoginClick();

        }
        void lblLoginClick()
        {
            lblLogin.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {
                    var login = new Login();
                    Navigation.PushAsync(login);

                })
            });
        }


    }
}