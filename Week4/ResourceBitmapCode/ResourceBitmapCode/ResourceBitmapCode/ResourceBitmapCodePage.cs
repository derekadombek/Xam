using System;
using Xamarin.Forms;

namespace ResourceBitmapCode
{
    public class ResourceBitmapCodePage : ContentPage
    {
        public ResourceBitmapCodePage()
        {
            Content = new Image
            {
                Source = ImageSource.FromResource(
                            "ResourceBitmapCode.Images.ModernUserInterface.jpg"),
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center
            };
        }
    }
}
