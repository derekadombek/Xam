using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ColorViewList
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ColorViewListPage();
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
