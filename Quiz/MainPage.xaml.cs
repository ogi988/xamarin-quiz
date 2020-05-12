using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Quiz
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            lblRegisterClick();
        }

        private void btnLogin(object sender, EventArgs e)
        {

            //var nameValue = name.Text;
            //var passwordValue = password.Text;
            
            var dashborad = new Dashboard();
            Navigation.PushAsync(dashborad);
            NavigationPage.SetHasNavigationBar(dashborad, false);
            
            
        }
        void lblRegisterClick()
        {
            lblRegister.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {
                    var register = new Register();
                    Navigation.PushAsync(register);
                    NavigationPage.SetHasNavigationBar(register, false);
                })
            });
        }
    }
}
