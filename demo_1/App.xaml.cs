using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using demo_1.Views.Home;
namespace demo_1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Principal();
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
    }
}
