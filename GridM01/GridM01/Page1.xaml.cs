using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GridM01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void btVoltar(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }

        private void btIr(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }
    }
}