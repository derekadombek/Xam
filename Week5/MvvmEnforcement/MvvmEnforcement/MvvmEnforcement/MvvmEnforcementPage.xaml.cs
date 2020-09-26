using System;
using Xamarin.Forms;

namespace MvvmEnforcement
{
    public partial class MvvmEnforcementPage : ContentPage
    {
        public MvvmEnforcementPage()
        {
            InitializeComponent();
        }

        async void OnGoToButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new MvvmEnforcementModalPage());
        }
    }
}

