﻿using StudentAppFirebase.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace StudentAppFirebase
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

         //   MainPage = new StudentAppFirebase.MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts

          MainPage=new   StudentPage();
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
