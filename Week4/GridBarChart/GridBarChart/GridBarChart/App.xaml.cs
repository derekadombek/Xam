using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GridBarChart
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new GridBarChartPage();
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
