using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SpelKoning
{
    public partial class Land1 : ContentPage
    {
        private double level = 1;
        private double widthh;

        public Land1()
        {
            InitializeComponent();
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
            widthh = width;

            if (width >= 1195)
            {
                MenuChanger(200);
                PijlChanger(150);
                if (Device.RuntimePlatform == Device.iOS)
                {
                    this.BackgroundImageSource =  level + "13.png";
                }
                else if (Device.RuntimePlatform == Device.Android)
                {
                    this.BackgroundImageSource = "http://i456314.hera.fhict.nl/" + level + "13.png";
                }
            }
            else if (width >= 1130)
            {
                MenuChanger(174);
                PijlChanger(131);
                if (Device.RuntimePlatform == Device.iOS)
                {
                    this.BackgroundImageSource = level + "11.png";
                }
                else if (Device.RuntimePlatform == Device.Android)
                {
                    this.BackgroundImageSource = "http://i456314.hera.fhict.nl/" + level + "11.png";
                }
            }
            else if (width >= 900)
            {
                PijlChanger(112);
                MenuChanger(149);
                if (Device.RuntimePlatform == Device.iOS)
                {
                    this.BackgroundImageSource =  level + "9.png";
                }
                else if (Device.RuntimePlatform == Device.Android)
                {
                    this.BackgroundImageSource = "http://i456314.hera.fhict.nl/" + level + "9.png";
                }
            }
            else
            {
                PijlChanger(98);
                MenuChanger(131);
                if (Device.RuntimePlatform == Device.iOS)
                {
                    this.BackgroundImageSource = level + "6.png";
                }
                else if (Device.RuntimePlatform == Device.Android)
                {
                    this.BackgroundImageSource = "http://i456314.hera.fhict.nl/" + level + "6.png";
                }
            }
        }

        private void MenuChanger(int i)
        {
            speel.WidthRequest = i;
        }

        private void BackgroundChanger()
        {
            if (widthh >= 1195)
            {
                if (Device.RuntimePlatform == Device.iOS)
                {
                    this.BackgroundImageSource = level + "13.png";
                }
                else if (Device.RuntimePlatform == Device.Android)
                {
                    this.BackgroundImageSource = "http://i456314.hera.fhict.nl/" + level + "13.png";
                }
            }
            else if (widthh >= 1130)
            {
                if (Device.RuntimePlatform == Device.iOS)
                {
                    this.BackgroundImageSource = level + "11.png";
                }
                else if (Device.RuntimePlatform == Device.Android)
                {
                    this.BackgroundImageSource = "http://i456314.hera.fhict.nl/" + level + "11.png";
                }
            }
            else if (widthh >= 900)
            {
                if (Device.RuntimePlatform == Device.iOS)
                {
                    this.BackgroundImageSource = level + "9.png";
                }
                else if (Device.RuntimePlatform == Device.Android)
                {
                    this.BackgroundImageSource = "http://i456314.hera.fhict.nl/" + level + "9.png";
                }
            }
            else
            {
                if (Device.RuntimePlatform == Device.iOS)
                {
                    this.BackgroundImageSource = level + "6.png";
                }
                else if (Device.RuntimePlatform == Device.Android)
                {
                    this.BackgroundImageSource = "http://i456314.hera.fhict.nl/" + level + "6.png";
                }
            }
        }

        async void Left(object sender, EventArgs e)
        {
            await pijllinks.RelScaleTo(0.05, 50);
            await pijllinks.ScaleTo(1, 50);
            switch (level)
            {
                case 1:
                    await Navigation.PushModalAsync(new WereldKiezer(), false);
                    break;
                case 2:
                    level--;
                    BackgroundChanger();
                    break;
                case 3:
                    level--;
                    BackgroundChanger();
                    break;
                case 4:
                    level--;
                    BackgroundChanger();
                    break;
                case 5:
                    level--;
                    BackgroundChanger();
                    break;
            }
        }

        async void Right(object sender, EventArgs e)
        {
            await pijlrechts.RelScaleTo(0.05, 50);
            await pijlrechts.ScaleTo(1, 50);
            switch (level)
            {
                case 1:
                    level++;
                    BackgroundChanger();
                    break;
                case 2:
                    level++;
                    BackgroundChanger();
                    break;
                case 3:
                    level++;
                    BackgroundChanger();
                    break;
                case 4:
                    level++;
                    BackgroundChanger();
                    break;
                case 5:
                    //Door naar nieuwe wereld
                    break;
            }
        }

        private void PijlChanger(int i)
        {
            pijllinks.WidthRequest = i;
            pijllinks.HeightRequest = i;
            pijlrechts.WidthRequest = i;
            pijlrechts.HeightRequest = i;
        }

        async void SpeelKnop(object sender, EventArgs e)
        {
            switch (level)
            {
                case 1:
                    await Navigation.PushModalAsync(new Game(), false);
                    break;
                case 2:
                    await DisplayAlert("Error", "Level niet beschikbaar.", "Ok");
                    break;
                case 3:
                    await DisplayAlert("Error", "Level niet beschikbaar.", "Ok");
                    break;
                case 4:
                   await DisplayAlert("Error", "Level niet beschikbaar.", "Ok");
                    break;
                case 5:
                    break;
            }
        }
    }
}
