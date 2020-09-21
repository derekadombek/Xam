using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ImageTap
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImageTapPage : ContentPage
    {
        public ImageTapPage()
        {
            InitializeComponent();
        }

        void OnImageTapped(object sender, EventArgs args)
        {
            Image image = (Image)sender;
            image.Opacity = 0.75;

            Device.StartTimer(TimeSpan.FromMilliseconds(100), () =>
            {
                image.Opacity = 1;
                return false;
            });

            label.Text = String.Format("Rendered image is {0} x {1}",
                                        image.Source, image.Width, image.Height);
        }
    }
}
