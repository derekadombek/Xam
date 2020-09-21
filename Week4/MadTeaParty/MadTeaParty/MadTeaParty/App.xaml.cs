using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MadTeaParty
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MadTeaPartyPage();
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
