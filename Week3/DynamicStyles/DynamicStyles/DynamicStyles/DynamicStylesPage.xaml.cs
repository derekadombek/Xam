using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DynamicStyles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DynamicStylesPage : ContentPage
    {
        public DynamicStylesPage()
        {
            InitializeComponent();
        }

        void OnButtonClicked(Object sender, EventArgs args)
        {
            Button button = (Button)sender;
            string resource = button.StyleId;
            Resources["buttonStyle"] = Resources[resource];
        }

        //void OnButton1Clicked(object sender, EventArgs args)
        //{
        //    Resources["buttonStyle"] = Resources["buttonStyle1"];
        //}

        //void OnButton2Clicked(object sender, EventArgs args)
        //{
        //    Resources["buttonStyle"] = Resources["buttonStyle2"];
        //}

        //void OnButton3Clicked(object sender, EventArgs args)
        //{
        //    Resources["buttonStyle"] = Resources["buttonStyle3"];
        //}

        void OnResetButtonClicked(object sender, EventArgs args)
        {
            Resources["buttonStyle"] = null;
        }
    }
}
