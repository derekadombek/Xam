using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Showcase
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShowcasePage : ContentPage
    {
        Marquee.Marquee marqueeA;
        Marquee.Marquee marqueeB;
        Marquee.Marquee marqueeC;
        Marquee.Marquee marqueeD;
        FizzBuzzPage fizzBuzzPage = new FizzBuzzPage();
        CircleButtonPage circleButtonPage = new CircleButtonPage();
        LightBrightPage lightBrightPage = new LightBrightPage();
        MonkeyTapWithSoundPage monkeyTapWithSoundPage = new MonkeyTapWithSoundPage();
        public ShowcasePage()
        {
            InitializeComponent();

            // 
            string title = "A New FizzBuzz that iterates";
            string buttonLabel = "FizzBuzz";
            // the numbers are the grid origin for this marquee.
            marqueeA = new Marquee.Marquee(mainGrid, contentView, 0, 20, buttonLabel, title);
            // can't add the clicked handler in Marquee because it has the wrong context.
            marqueeA.button.Clicked += OnFizzBuzzButtonClicked;

            title = "Draw something";
            buttonLabel = "Light Bright";
            marqueeB = new Marquee.Marquee(mainGrid, contentView, 0, 0, buttonLabel, title);
            marqueeB.button.Clicked += OnLightBrightClicked;

            title = "Play Monkey Tap! memorize the patterns and tap away!";
            buttonLabel = "Monkey Tap";
            marqueeC = new Marquee.Marquee(mainGrid, contentView, 20, 0, buttonLabel, title);
            marqueeC.button.Clicked += OnMonkeyTapButtonClicked;

            title = "Watch the button go in a circle while the color changes";
            buttonLabel = "Circle Button";
            marqueeD = new Marquee.Marquee(mainGrid, contentView, 20, 20, buttonLabel, title);
            marqueeD.button.Clicked += OnCircleButtonClicked;
        }

        async void OnFizzBuzzButtonClicked(object sender, EventArgs args)
        {
            NavigationPage.SetHasBackButton(this, true);
            NavigationPage.SetHasNavigationBar(this, false);
            fizzBuzzPage.Title = "FizzBuzz";
            await Navigation.PushAsync(fizzBuzzPage);
        }
        async void OnCircleButtonClicked(object sender, EventArgs args)
        {
            NavigationPage.SetHasBackButton(this, true);
            NavigationPage.SetHasNavigationBar(this, false);
            circleButtonPage.Title = "CircleButton";
            await Navigation.PushAsync(circleButtonPage);
        }
        async void OnLightBrightClicked(object sender, EventArgs args)
        {
            NavigationPage.SetHasBackButton(this, true);
            NavigationPage.SetHasNavigationBar(this, false);
            lightBrightPage.Title = "LightBright";
            await Navigation.PushAsync(lightBrightPage);
        }
        async void OnMonkeyTapButtonClicked(object sender, EventArgs args)
        {
            NavigationPage.SetHasBackButton(this, true);
            NavigationPage.SetHasNavigationBar(this, false);
            monkeyTapWithSoundPage.Title = "MonkeyTap";
            await Navigation.PushAsync(monkeyTapWithSoundPage);
        }
    }
}