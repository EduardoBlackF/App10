using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App10
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btn1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ViewToViewDemo());
        }

        private async void btn2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BindingModeDemo());
        }

        private async void btn3_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListViewDemo());
        }

        private async void btn4_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PickerDemo());
        }
    }
}
