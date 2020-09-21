using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ImageTap
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ImageTapPage();
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
