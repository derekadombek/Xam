using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChessboardProportional
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ChessboardProportionalPage();
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
