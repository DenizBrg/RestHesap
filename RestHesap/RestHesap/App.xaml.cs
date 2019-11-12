using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RestHesap
{
    public partial class App : Application
    {
        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTU3MTUxQDMxMzcyZTMzMmUzMEQ3clNiQWtMaTRMdDVnQzY1dFRPa09LM0ZiV1FpaEQwN2hndTRUU3VrcmM9");
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
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
