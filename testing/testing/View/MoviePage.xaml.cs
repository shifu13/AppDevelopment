using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testing.Data;
using testing.DataModel;
using testing.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace testing
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MoviePage : ContentPage
    {
        public MoviePage()
        {
            InitializeComponent();
            BindingContext = new MoviePageViewModel();
        }
        private async void OnItemSelected(Object sender, ItemTappedEventArgs e)
        {
            var mydetails = e.Item as Movie;
            await Navigation.PushAsync(new MyMoviePageDetail(mydetails.Name, mydetails.Resume, mydetails.Director, mydetails.Writers, mydetails.Image));
        }
    }
}