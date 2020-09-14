using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CustomExtensionDemo
{
    public partial class App : Application
    {
        public App()
        {
            Xamarin.FormsBook.Toolkit.Toolkit.Init();

            InitializeComponent();

            MainPage = new CustomExtensionDemoPage();
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
