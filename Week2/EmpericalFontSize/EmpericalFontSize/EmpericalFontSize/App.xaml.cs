using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EmpericalFontSize
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new EmpericalFontSizePage();
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
