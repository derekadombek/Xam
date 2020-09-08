using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamlKeypad
{
    public partial class App : Application
    {
        const string displayLabelText = "displayLabelText";
        public string DisplayLabelText { get; set; }
        public App()
        {
            if (Properties.ContainsKey(displayLabelText))
            {
                DisplayLabelText = (string)Properties[displayLabelText];
            }

            InitializeComponent();

            MainPage = new XamlKeypadPage();
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
