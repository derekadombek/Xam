using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MvvmEnforcement
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MvvmEnforcementPage();
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
