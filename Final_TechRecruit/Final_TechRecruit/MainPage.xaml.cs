using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
namespace Final_TechRecruit
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void WebDesigners_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new webDesPage());
        }
        private async void WebDevelopers_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WDevPage());
        }
        private async void DatabaseDev_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DatabaseDevPage());
        }

    }
}
