﻿using Microsoft.Extensions.DependencyInjection;
using Profile.Services;
using Profile.ViewModel;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Profile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            
           MainPage = new MainPage();
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
