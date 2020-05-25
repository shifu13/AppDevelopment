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
    public partial class MyMoviePageDetail : ContentPage
    {
        public MyMoviePageDetail(string Name, string Resume, string Director, string Writers, string source)
        {
            InitializeComponent();
            MyImageCall.Source = new UriImageSource()
            {
                Uri = new Uri(source)
            };

            MyNameCall.Text = Name;
            MyResumeCall.Text = Resume;
            MyDirectorCall.Text = Director;
            MyWritersCall.Text = Writers;
        }
    }
}