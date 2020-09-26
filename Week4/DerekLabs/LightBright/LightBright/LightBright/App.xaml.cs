using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LightBright
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LightBrightPage();
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
