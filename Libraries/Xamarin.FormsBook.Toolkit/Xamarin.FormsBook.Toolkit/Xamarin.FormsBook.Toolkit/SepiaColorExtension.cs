using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin.FormsBook.Toolkit
{
    public class SepiaColorExtension : IMarkupExtension
    {
        public SepiaColorExtension()
        {
            A = 1;
        }

        public double R { set; get; }

        public double G { set; get; }

        public double B { set; get; }

        public double A { set; get; }

        public object ProvideValue(IServiceProvider service)
        {
            double sepiaR = 0.393 * R + 0.769 * G + 0.189 * B;
            double sepiaG = 0.349 * R + 0.686 * G + 0.168 * B;
            double sepiaB = 0.272 * R + 0.534 * G + 0.131 * B;
            return Color.FromRgba(sepiaR, sepiaG, sepiaB, A);
        }
    }
}

