using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Currency_GuessMyNumber
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void NavigateButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }

            private void Button_Clicked(object sender, EventArgs e)
        {
            float Value=0;
            if (!string.IsNullOrEmpty(EntryValue.Text))
            {
                Value = float.Parse(EntryValue.Text);
                
            }
             else
                PrintValue.Text = "Nu ati introdus corect";

            EntryValue.Text = null;
            PrintValue.Text =$"{(Value * 4.95).ToString()} Lei  " ;
        }
    }
}
