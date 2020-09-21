using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GridRgbSliders
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new GridRgbSlidersPage();
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
