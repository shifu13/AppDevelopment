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

namespace testing
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        private const string Url = "https://the-one-api.herokuapp.com/v1/book";
        private HttpClient _client = new HttpClient();

        public Page1()
        {
            InitializeComponent();
            OnAppearing();
            Title = "Go back";

        }

        protected override async void OnAppearing()
        {
            var content = await _client.GetStringAsync(Url);
            var obj = JsonConvert.DeserializeObject<Welcome>(content);
            var test = obj.Docs;

            MovieListView.ItemsSource = test;
        }

        async void OnPreviousPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        async private void MovieListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            Doc selected = (Doc)((ListView)sender).SelectedItem;

            await Navigation.PushAsync(new FirstBook(selected.Name));

            ((ListView)sender).SelectedItem = null;
        }
    }
}