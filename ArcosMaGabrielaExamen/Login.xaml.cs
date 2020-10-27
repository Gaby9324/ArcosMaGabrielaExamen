using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ArcosMaGabrielaExamen
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            
            var usuario = "estudiante2020";
            var password = "uisrael2020";
            if (txtUsu.Text == usuario && txtPass.Text == password)
            {
                await Navigation.PushAsync(new Registro(usuario,password));
            }
            else
            {
                txtUsu.Text = "";
                txtPass.Text = "";
                DisplayAlert("Login", "Usuario contrasena incorrecta", "ok");
            

        }
    }
    }
}
