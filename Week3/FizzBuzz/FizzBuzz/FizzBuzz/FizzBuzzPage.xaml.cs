using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FizzBuzz
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FizzBuzzPage : ContentPage
    {
        public FizzBuzzPage()
        {
            InitializeComponent();

            for (int i = 0; i < 101; i++)
            {
                string number = Convert.ToString(i);
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Label label = new Label
                    {
                        TextColor = Color.Blue,
                        Text = "FizzBuzz"
                    };
                    stackLayout.Children.Add(label);
                }
                else if (i % 3 == 0)
                {
                    Label label = new Label
                    {
                        TextColor = Color.Red,
                        Text = "Fizz"
                    };
                    stackLayout.Children.Add(label);
                }
                else if (i % 5 == 0)
                {
                    Label label = new Label
                    {
                        TextColor = Color.Green,
                        Text = "Buzz"
                    };
                    stackLayout.Children.Add(label);
                }
                else
                {
                    Label label = new Label
                    {
                        Text = number,
                    };
                    stackLayout.Children.Add(label);
                }
            }
        }
    }
}