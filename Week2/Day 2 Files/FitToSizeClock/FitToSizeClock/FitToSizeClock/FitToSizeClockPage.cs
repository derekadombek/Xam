using System;
using Xamarin.Forms;

namespace FitToSizeClock
{
    public class FitToSizeClockPage : ContentPage
    {
        public FitToSizeClockPage()
        {
            Label clockLabel = new Label
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            

            clockLabel.SizeChanged += OnPageChanged;
            Content = clockLabel;
        }
        // Handle the SizeChanged event for the page.
        void OnPageChanged(object sender, EventArgs args)
            {
            Label clockLabel = (Label)sender;
                // Scale the font size to the page width
                //      (based on 11 characters in the displayed string).
                if (this.Width > 0)
                    clockLabel.FontSize = this.Width / 6;
            

            // Start the timer going.
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                // Set the Text property of the Label.
                clockLabel.Text = DateTime.Now.ToString("h:mm:ss tt");
                return true;
            });
        }
    }
}
