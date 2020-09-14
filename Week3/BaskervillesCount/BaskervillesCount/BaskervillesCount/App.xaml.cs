using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BaskervillesCount
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new BaskervillesCountPage();
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
