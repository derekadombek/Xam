using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;

using Xamarin.Forms;

namespace BlackCat
{
    public class BlackCatPage : ContentPage
    {
        public BlackCatPage()
        {
            StackLayout mainStack = new StackLayout();
            StackLayout textStack = new StackLayout
            {
                Padding = new Thickness(5),
                Spacing = 10
            };

            Assembly assembly = GetType().GetTypeInfo().Assembly;
            string resource = "BlackCat.Texts.blackcat.txt";

            using (Stream stream = assembly.GetManifestResourceStream(resource))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    bool gotTitle = false;
                    string line;

                    while (null != (line = reader.ReadLine()))
                    {
                        Label label = new Label
                        {
                            Text = line,

                            TextColor = Color.Black
                        };

                        if (!gotTitle)
                        {
                            label.HorizontalOptions = LayoutOptions.Center;
                            label.FontSize = Device.GetNamedSize(NamedSize.Medium, label);
                            label.FontAttributes = FontAttributes.Bold;
                            mainStack.Children.Add(label);
                            gotTitle = true;
                        }
                        else
                        {
                            textStack.Children.Add(label);

                        }
                    }
                }
            }
            //put the textstack in a scrollview with fillandexpand
            ScrollView scrollView = new ScrollView
            {
                Content = textStack,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Padding = new Thickness(5, 0)
            };
            //add the scrollview as a seconf chilf of the mainstack
            mainStack.Children.Add(scrollView);

            //set page content to mainstack
            Content = mainStack;

            //White background for ebooks
            BackgroundColor = Color.White;

            //
            Padding = new Thickness(0, Device.RuntimePlatform == Device.iOS ? 20 : 0, 0, 0);
        }
    }
}