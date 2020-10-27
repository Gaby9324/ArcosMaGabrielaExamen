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
    public partial class Resumen : ContentPage
    {
        public Resumen(string nom, string mon, string cuo)
        {
            InitializeComponent();
            string nombre= lblNombre.Text;
            lblNombre.Text = nombre + nom;

            string monto = lblMonto.Text;
            lblMonto.Text = monto + mon;

            string cuota = lblCuota.Text;
            lblCuota.Text = cuota + cuo;

        }

        private  async void btnSalir_Clicked(object sender, EventArgs e)
        {
          
        }
    }
}