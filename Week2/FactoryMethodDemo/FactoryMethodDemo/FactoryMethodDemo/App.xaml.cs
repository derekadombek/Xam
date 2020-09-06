using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FactoryMethodDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new FactoryMethodDemoPage();
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
