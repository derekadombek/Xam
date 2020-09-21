using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ToolbarDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage (new ToolbarDemoPage());
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
