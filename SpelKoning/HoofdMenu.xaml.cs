using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SpelKoning
{
    public partial class HoofdMenu : ContentPage
    {
        public HoofdMenu()
        {
            InitializeComponent();
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);

            if (width >= 1195)
            {
                MenuChanger(400);
                if (Device.RuntimePlatform == Device.iOS)
                {
                    this.BackgroundImageSource = "background213.png";
                }
                else if (Device.RuntimePlatform == Device.Android)
                {
                    this.BackgroundImageSource = "http://i456314.hera.fhict.nl/background213.png";
                }
            }
            else if (width >= 1130)
            {
                MenuChanger(349);
                if (Device.RuntimePlatform == Device.iOS)
                {
                    this.BackgroundImageSource = "background211.png";
                }
                else if (Device.RuntimePlatform == Device.Android)
                {
                    this.BackgroundImageSource = "http://i456314.hera.fhict.nl/background211.png";
                }
            }
            else if (width >= 900)
            {
                MenuChanger(262);
                if (Device.RuntimePlatform == Device.iOS)
                {
                    this.BackgroundImageSource = "background29.png";
                }
                else if (Device.RuntimePlatform == Device.Android)
                {
                    this.BackgroundImageSource = "http://i456314.hera.fhict.nl/background29.png";
                }
            }
            else
            {
                MenuChanger(262);
                if (Device.RuntimePlatform == Device.iOS)
                {
                    this.BackgroundImageSource = "background26.png";
                }
                else if (Device.RuntimePlatform == Device.Android)
                {
                    this.BackgroundImageSource = "http://i456314.hera.fhict.nl/background26.png";
                }
            }
        }

        async void Button_OnClicked(object sender, EventArgs e)
        {
            await speel.RelScaleTo(0.05, 50);
            await speel.ScaleTo(1, 50);
            await Navigation.PushModalAsync(new WereldKiezer(), false);
        }

        async void StopKnop(object sender, EventArgs e)
        {
            await terug.RelScaleTo(0.05, 50);
            await terug.ScaleTo(1, 50);
            await Navigation.PushModalAsync(new MainPage(), false);
        }

        async void adminknop(object sender, EventArgs e)
        {
            await leraar.RelScaleTo(0.05, 50);
            await leraar.ScaleTo(1, 50);
            await Navigation.PushModalAsync(new Admin(), false);
        }

        async void instellingen(object sender, EventArgs e)
        {
            await opties.RelScaleTo(0.05, 50);
            await opties.ScaleTo(1, 50);
            await Navigation.PushModalAsync(new Credits(), false);
            //
        }

        private void MenuChanger(int i)
        {
            speel.WidthRequest = i;
            opties.WidthRequest = i;
            leraar.WidthRequest = i;
            terug.WidthRequest = i;
        }
    }
}
