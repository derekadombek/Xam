using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DynamicVsStaticCode
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new DynamicVsStaticCodePage();
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
