using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StackedBitmap
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new StackedBitmapPage();
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
