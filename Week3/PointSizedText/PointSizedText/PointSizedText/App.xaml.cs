using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PointSizedText
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PointSizedTextPage();
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
