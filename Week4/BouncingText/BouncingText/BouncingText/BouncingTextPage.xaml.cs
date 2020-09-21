using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BouncingText
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BouncingTextPage : ContentPage
    {
        const double period = 2000;
        readonly DateTime startTime = DateTime.Now;

        public BouncingTextPage()
        {
            InitializeComponent();
            Device.StartTimer(TimeSpan.FromMilliseconds(15), OnTimerTick);
        }

        bool OnTimerTick()
        {
            TimeSpan elapsed = DateTime.Now - startTime;
            double t = (elapsed.TotalMilliseconds % period) / period;
            t = 2 * (t < 0.5 ? t : 1 - t);

            label1.TextColor = Color.FromHsla(t, 1, 0.5);

            AbsoluteLayout.SetLayoutBounds(label1,
                new Rectangle(t, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

            AbsoluteLayout.SetLayoutBounds(label2,
                new Rectangle(0.5, 1 - t, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

            return true;
        }
    }
}
