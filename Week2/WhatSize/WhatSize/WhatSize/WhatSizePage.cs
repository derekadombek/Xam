using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

using Xamarin.Forms;

namespace WhatSize
{
    public class WhatSizePage : ContentPage
    {
        Label label;
        public WhatSizePage()
        {
            label = new Label
            {
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            Content = label;

            SizeChanged += OnPageSizeChanged;
        }
        void OnPageSizeChanged(object sender, EventArgs args)
        {
            label.Text = String.Format("{0} \u00d7 {1}", Width, Height);
        }
    }
}