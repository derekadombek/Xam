using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Greetings
{
    public class greetingspage : ContentPage
    {
        public greetingspage()
        {
            Content = new Label()
            {
                Text = "Greetings, Xamarin.Forms!",
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                BackgroundColor = Color.Yellow,
                TextColor = Color.Blue
            };
            Padding = new Thickness(5, Device.RuntimePlatform == Device.iOS ? 25 : 5, 5, 5);
        }
    }
}