using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ClassHierarchy
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ClassHierarchyPage();
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
