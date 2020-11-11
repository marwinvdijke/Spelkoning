using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SpelKoning
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void OnImageNameTapped(object sender, EventArgs args)
        {
            try
            {
                await Navigation.PushModalAsync(new HoofdMenu(), false);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);

            if (width >= 1195)
            {
                if (Device.RuntimePlatform == Device.iOS)
                {
                    this.BackgroundImageSource = "main13.png";
                }
                else if (Device.RuntimePlatform == Device.Android)
                {
                    this.BackgroundImageSource = "http://i456314.hera.fhict.nl/main13.png";
                }
            }
            else if (width >= 1130)
            {
                if (Device.RuntimePlatform == Device.iOS)
                {
                    this.BackgroundImageSource = "main11.png";
                }
                else if (Device.RuntimePlatform == Device.Android)
                {
                    this.BackgroundImageSource = "http://i456314.hera.fhict.nl/main11.png";
                }
            }
            else if (width >= 900)
            {
                if (Device.RuntimePlatform == Device.iOS)
                {
                    this.BackgroundImageSource = "main9.png";
                }
                else if (Device.RuntimePlatform == Device.Android)
                {
                    this.BackgroundImageSource = "http://i456314.hera.fhict.nl/main9.png";
                }
            }
            else
            {
                if (Device.RuntimePlatform == Device.iOS)
                {
                    this.BackgroundImageSource = "main6.png";
                }
                else if (Device.RuntimePlatform == Device.Android)
                {
                    this.BackgroundImageSource = "http://i456314.hera.fhict.nl/main6.png";
                }
            }
        }
    }
}
