using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace WebBitmapCode
{
    public class WebBitmapCodePage : ContentPage
    {
        public WebBitmapCodePage()
        {
            //string uri = "https://raw.githubusercontent.com/xamarin/docs-archive/master/Images/stock/small/IMG_1415.JPG";
            Content = new Image
            {
                //Source = ImageSource.FromUri(new Uri(uri))
                //Source = "https://raw.githubusercontent.com/xamarin/docs-archive/master/Images/stock/small/IMG_1415.JPG"
                Source = new UriImageSource
                {
                    Uri = new Uri("https://raw.githubusercontent.com/xamarin/docs-archive/master/Images/stock/small/IMG_1415.JPG")
                }
            };
        }
    }
}