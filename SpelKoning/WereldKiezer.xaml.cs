using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SpelKoning
{
    public partial class WereldKiezer : ContentPage
    {
        public WereldKiezer()
        {
            InitializeComponent();
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);

            if (width >= 1195)
            {
                PijlChanger(150);
                if (Device.RuntimePlatform == Device.iOS)
                {
                    this.BackgroundImageSource = "map113.png";
                }
                else if (Device.RuntimePlatform == Device.Android)
                {
                    this.BackgroundImageSource = "http://i456314.hera.fhict.nl/map113.png";
                }
            }
            else if (width >= 1130)
            {
                PijlChanger(131);
                if (Device.RuntimePlatform == Device.iOS)
                {
                    this.BackgroundImageSource = "map111.png";
                }
                else if (Device.RuntimePlatform == Device.Android)
                {
                    this.BackgroundImageSource = "http://i456314.hera.fhict.nl/map111.png";
                }
            }
            else if (width >= 900)
            {
                PijlChanger(112);
                if (Device.RuntimePlatform == Device.iOS)
                {
                    this.BackgroundImageSource = "map19.png";
                }
                else if (Device.RuntimePlatform == Device.Android)
                {
                    this.BackgroundImageSource = "http://i456314.hera.fhict.nl/map19.png";
                }
            }
            else
            {
                PijlChanger(98);
                if (Device.RuntimePlatform == Device.iOS)
                {
                    this.BackgroundImageSource = "map16.png";
                }
                else if (Device.RuntimePlatform == Device.Android)
                {
                    this.BackgroundImageSource = "http://i456314.hera.fhict.nl/map16.png";
                }
            }
        }

        async void Left(object sender, EventArgs e)
        {
            await pijllinks.RelScaleTo(0.05, 50);
            await pijllinks.ScaleTo(1, 50);
            await Navigation.PushModalAsync(new HoofdMenu(), false);
        }

        async void Right(object sender, EventArgs e)
        {
            await pijlrechts.RelScaleTo(0.05, 50);
            await pijlrechts.ScaleTo(1, 50);
            await Navigation.PushModalAsync(new Land1(), false);
        }

        private void PijlChanger(int i)
        {
            pijllinks.WidthRequest = i;
            pijllinks.HeightRequest = i;
            pijlrechts.WidthRequest = i;
            pijlrechts.HeightRequest = i;
        }
    }
}
