using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SpelKoning
{
    public partial class Admin : ContentPage
    {


        public Admin()
        {
            InitializeComponent();

        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = await App.Database.GetAccountsAsync();
        }

        async void OnButtonClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nameEntry.Text) && !string.IsNullOrWhiteSpace(password.Text))
            {
                await App.Database.SavePersonAsync(new Data.Account()
                {
                    FullName = nameEntry.Text,
                    Voortgang = 1,
                    Wachtwoord = password.Text
                });

                nameEntry.Text = password.Text = string.Empty;
                listView.ItemsSource = await App.Database.GetAccountsAsync();
            }
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);

            if (width >= 1195)
            {
                //13 inch
                MenuChanger(200);
            }
            else if (width >= 1130)
            {
                //11 inch
                MenuChanger(174);
            }
            else if (width >= 900)
            {
                //9 inch
                MenuChanger(149);
            }
            else
            {
                //6 inch
                MenuChanger(131);
            }
        }

        private void MenuChanger(int i)
        {
            terug.WidthRequest = i;
        }

        async void StopKnop(object sender, EventArgs e)
        {
            await terug.RelScaleTo(0.05, 50);
            await terug.ScaleTo(1, 50);
            await Navigation.PushModalAsync(new HoofdMenu());
        }
    }
}
