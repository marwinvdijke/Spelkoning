using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SpelKoning
{
    public partial class Game : ContentPage
    {
        string[] woorden =
                {
            "vis", "boot", "mier", "lat", "boom", "tak", "maan", "roos", "bloem", "deur", "pen", "bol", "rat", "nul",
            "bal", "tor", "man", "kar", "som", "pan", "dak", "jas", "nek", "doos", "haas", "zaag", "geef", "roos",
            "boog", "muur", "duur", "noot", "pijn", "bijl", "doek", "boek", "bijl", "fijn", "zoen", "wijk"
        };

        string huidigwoord;
        private string scrambledwoord;
        int id;
        int score;
        private int max = 10;

        Random random = new Random();
        Random rand = new Random(10000);

        public Game()
        {
            InitializeComponent();
            NieuwWoord();
            submitknop.WidthRequest = 35;
            submitknop.HeightRequest = 35;
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);

            if (width >= 1195)
            {
                if (Device.RuntimePlatform == Device.iOS)
                {
                    this.BackgroundImageSource = "background13.png";
                }
                else if (Device.RuntimePlatform == Device.Android)
                {
                    this.BackgroundImageSource = "http://i456314.hera.fhict.nl/background13.png";
                }
            }
            else if (width >= 1130)
            {
                if (Device.RuntimePlatform == Device.iOS)
                {
                    this.BackgroundImageSource = "background11.png";
                }
                else if (Device.RuntimePlatform == Device.Android)
                {
                    this.BackgroundImageSource = "http://i456314.hera.fhict.nl/background11.png";
                }
            }
            else if (width >= 900)
            {
                if (Device.RuntimePlatform == Device.iOS)
                {
                    this.BackgroundImageSource = "background9.png";
                }
                else if (Device.RuntimePlatform == Device.Android)
                {
                    this.BackgroundImageSource = "http://i456314.hera.fhict.nl/background9.png";
                }
            }
            else
            {
                if (Device.RuntimePlatform == Device.iOS)
                {
                    this.BackgroundImageSource = "background6.png";
                }
                else if (Device.RuntimePlatform == Device.Android)
                {
                    this.BackgroundImageSource = "http://i456314.hera.fhict.nl/background6.png";
                }
            }
        }

        async void Quit_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage(), false);
        }

        void Hint_Clicked(System.Object sender, System.EventArgs e)
        {
            DisplayAlert("Hint:", ScrambleWord(huidigwoord), "Ok");
        }

        void OnEntryCompleted(object sender, EventArgs e)
        {
            string inputwoord = ((Entry)sender).Text;
            if (String.IsNullOrWhiteSpace(inputwoord))
            {
                DisplayAlert("Antwoord:", "Vul een antwoord in.", "ok");
            }
            else if (inputwoord == huidigwoord)
            {
                score++;
                scorename.Text = "score: " + Convert.ToString(score);
                NieuwWoord();
            }
            else
            {
                inputbox.Text = "";
                DisplayAlert("Antwoord:", "Fout Antwoord!", "ok");
            }
        }

        void Random_Generator()
        {
            max = max - score;
            id = random.Next(0, (woorden.Length));
        }

        void NieuwWoord()
        {
            inputbox.Text = "";
            Random_Generator();
            string woordstring = woorden[id];
            scrambledwoord = ScrambleWord(woordstring);
            woord.Text = scrambledwoord;
            huidigwoord = woordstring;
        }

        private string ScrambleWord(string word)
        {
            char[] chars = new char[word.Length];
            int index = 0;
            while (word.Length > 0)
            {
                int next = rand.Next(0, word.Length - 1);
                chars[index] = word[next];
                word = word.Substring(0, next) + word.Substring(next + 1);
                ++index;
            }

            return new String(chars);
        }

        async void Submit(object sender, EventArgs e)
        {
            await submitknop.RelRotateTo(360, 1000);

        }
    }
}
