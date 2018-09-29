using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Earthquake.Portable
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            txtUserName.Completed += (object sender, EventArgs e) =>
            {
                txtPassword.Focus();
            };
            txtPassword.Completed += (object sender, EventArgs e) =>
            {
                login();
            };
        }
        private void btnLoginClicked(object sender, EventArgs e)
        {
            login();
        }
        private void login()
        {
            DisplayAlert(txtUserName.Text, txtPassword.Text, "تایید");
        }

        private void btnReportFullClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ReportFull());
            //App.Current.MainPage = new ReportFull();
        }
    }
}
