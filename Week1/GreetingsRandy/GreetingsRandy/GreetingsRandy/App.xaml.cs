using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GreetingsRandy
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new GreetingRandyPage();
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
