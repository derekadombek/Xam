using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CircularText
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CircularTextPage();
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
