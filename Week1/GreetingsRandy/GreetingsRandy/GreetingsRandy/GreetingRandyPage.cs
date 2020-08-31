using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace GreetingsRandy
{
    public class GreetingRandyPage : ContentPage
    {
        public GreetingRandyPage()
        {
            FormattedString formattedString = new FormattedString();

            formattedString.Spans.Add(new Span
            {
                Text = "Hi, Randy!" + Environment.NewLine,
                ForegroundColor = Color.Red
            });

            formattedString.Spans.Add(new Span
            {
                Text = "This is Derek." + Environment.NewLine,
                ForegroundColor = Color.Green
            });

            formattedString.Spans.Add(new Span
            {
                Text = "SWDV 265 Mobile Apps Development" + Environment.NewLine,
                ForegroundColor = Color.Blue
            });
            Content = new Label
            {
                FormattedText = formattedString,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };
        }
    }
}