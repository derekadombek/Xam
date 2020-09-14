using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PropertySettings
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PropertySettingsPage();
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
