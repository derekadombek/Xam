using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WebBitmapXaml
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new WebBitmapXamlPage();
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
