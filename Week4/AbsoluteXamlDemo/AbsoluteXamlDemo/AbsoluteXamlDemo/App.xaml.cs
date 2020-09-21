using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AbsoluteXamlDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AbsoluteXamlDemoPage();
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
