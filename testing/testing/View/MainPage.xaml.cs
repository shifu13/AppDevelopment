using System;
using testing;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Globalization;
using Newtonsoft.Json.Converters;
using testing.Data;
using testing.View;

namespace testing
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

            Title = "Front Page";
        }
        async void OnNextPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }

        async void OnFilmPageButtonClicked(object sender, EventArgs e) {
            await Navigation.PushAsync(new MoviePage());
        }

        async void OnQuotePageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new QuotePage());
        }

    }
}
