using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace testing
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstBook : ContentPage
    {
        public FirstBook(string Name)
        {
            InitializeComponent();
            BookName.Text = Name;
            Title = "Go back";
        }

        async void OnPreviousPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}