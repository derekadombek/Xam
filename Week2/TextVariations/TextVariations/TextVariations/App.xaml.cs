using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TextVariations
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TextVariationsPage();
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
