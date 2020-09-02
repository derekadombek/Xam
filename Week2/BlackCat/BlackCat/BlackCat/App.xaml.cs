using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BlackCat
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new BlackCatPage();
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
