using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Baskervilles
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new BaskervillesPage();
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
