using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JustNotes
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new JustNotesPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
            ((JustNotesPage)(((NavigationPage)MainPage).CurrentPage)).OnSleep();
        }

        protected override void OnResume()
        {
        }
    }
}
