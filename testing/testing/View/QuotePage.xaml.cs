using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testing.Data;
using testing.DataModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace testing.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuotePage : ContentPage
    {
        public QuotePage()
        {
            InitializeComponent();
            BindingContext = new QuotePageViewModel();
        }

        private async void OnItemSelected(Object sender, ItemTappedEventArgs e)
        {
            var mydetails = e.Item as Quote;
            await Navigation.PushAsync(new MyQuotePageDetail(mydetails.Text, mydetails.Image));
        }
    }
}