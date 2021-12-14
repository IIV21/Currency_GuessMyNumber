using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace Currency_GuessMyNumber
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int number = rnd.Next(1,100);
            TheRandomNumber.Text = number.ToString();
            Image.IsVisible = false;
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            int guess = Convert.ToInt32(Guess.Text);
            if (guess > Convert.ToInt32(TheRandomNumber.Text))
                Response.Text = "The number i'm thinking about is smaller than that. Try again";
            else if (guess < Convert.ToInt32(TheRandomNumber.Text))
                Response.Text = "The number i'm thinking about is bigger than that. Try again";
            else if (guess == Convert.ToInt32(TheRandomNumber.Text))
            {
                Response.Text = "That's The number, Congratulations";
                Image.IsVisible = true;
            }

        }

        
    }
}