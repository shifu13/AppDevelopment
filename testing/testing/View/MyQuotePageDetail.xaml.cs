using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace testing.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyQuotePageDetail : ContentPage
    {
        public MyQuotePageDetail(string Text, string source)
        {
            InitializeComponent();
            MyImageCall.Source = new UriImageSource()
            {
                Uri = new Uri(source)
            };

            MyQuoteCall.Text = Text;
        }
    }
}