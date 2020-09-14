using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SharedStatics
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new SharedStaticPage();
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
