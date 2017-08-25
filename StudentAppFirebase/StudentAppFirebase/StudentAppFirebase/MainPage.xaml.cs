using StudentAppFirebase.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StudentAppFirebase
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {

         //   await Navigation.PushAsync(new StudentDetailPage());

            //Navigation.InsertPageBefore(new StudentAppFirebase.Views.StudentDetailPage() , this);
            //await Navigation.PopAsync();
        }
    }
}
