﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TaskDelayClock
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TaskDelayClockPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
