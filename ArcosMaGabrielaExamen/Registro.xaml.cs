using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ArcosMaGabrielaExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro(string usuario, string password)
        {
            InitializeComponent();
            string user =lblUser.Text;
            lblUser.Text = user + usuario ;
        }

        private async void BtnGuardar_Clicked(object sender, EventArgs e)
        {
            string nom = txtNombre.Text;
            string mon = txtMonto.Text;
            string cuo = txtMensual.Text;
            await Navigation.PushAsync(new Resumen(nom,mon,cuo));
        }

        private void BtnCalcular_Clicked(object sender, EventArgs e)
        {
            try
            {
                double monto = Convert.ToDouble(txtMonto.Text);
                
                double cuota = ((1800 - monto) / 3);
                double porcentaje = cuota * 0.05;
                double cuotaFinal = cuota + porcentaje;
                txtMensual.Text = cuotaFinal.ToString();

            }
            catch (Exception ex)
            {
                DisplayAlert("Mensaje de Alerta ", "Error" + ex.Message, "ok");

            }
        }
    }
}