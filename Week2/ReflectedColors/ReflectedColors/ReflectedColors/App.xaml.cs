using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ReflectedColors
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ReflectedColorsPage();
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
