using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ResourceBitmapCode
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ResourceBitmapCodePage();
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
