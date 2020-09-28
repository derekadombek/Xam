using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace Showcase
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FizzBuzzPage : ContentPage
    {
        StackLayout stackLayout = new StackLayout();
        Label label = new Label()
        {
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center,
            Text = ""
        };
        Button resetButton = new Button()
        {
            Text = "Reset"
        };
        Button returnButton = new Button()
        {
            Text = "Return"
        };
        public FizzBuzzPage()
        {
            InitializeComponent();

            StackLayout stackLayout = new StackLayout();
            string result;

            returnButton.Clicked += ReturnButtonClicked;

            resetButton.Clicked += ResetButtonClicked;

            stackLayout.Children.Add(label);
            int count = 1;
            result = "";
            Device.StartTimer(TimeSpan.FromMilliseconds(750), () =>
            {
                if (count == 60)
                {
                    result += " FizzBuzz";
                    label.Text = result;
                    stackLayout.Children.Add(resetButton);
                    stackLayout.Children.Add(returnButton);
                    return false;
                }
                else if (count % 15 == 0)
                {
                    result = " FizzBuzz";
                }
                else if (count % 3 == 0)
                {
                    result = " Fizz";
                }
                else if (count % 5 == 0)
                {
                    result = " Buzz";
                }
                else
                {
                    result = count.ToString();
                }
                label.Text = result;
                ++count;
                return true;
            });
            Padding = new Thickness(20, 20, 20, 20);
            Content = new ScrollView()
            {
                Content = stackLayout
            };
        }

        void ReturnButtonClicked(object sender, EventArgs args)
        {
            Navigation.PopToRootAsync();
        }
        public void ResetButtonClicked(object sender, EventArgs args)
        {
            int count = 1;
            string result = "";
            Device.StartTimer(TimeSpan.FromMilliseconds(750), () =>
            {
                if (count == 60)
                {
                    result = "FizzBuzz";
                    label.Text = result;
                    stackLayout.Children.Add(returnButton);
                    stackLayout.Children.Add(resetButton);
                    return false;
                }
                else if (count % 15 == 0)
                {
                    result = "FizzBuzz";
                }
                else if (count % 3 == 0)
                {
                    result = "Fizz";
                }
                else if (count % 5 == 0)
                {
                    result = "Buzz";
                }
                else
                {
                    result = count.ToString();
                }
                label.Text = result;
                ++count;
                return true;
            });
        }
    }
}