using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace app_ex
{
    public partial class MainPage : ContentPage
    {
        string errorMessage = null;
        public MainPage()
        {
            InitializeComponent();
        }

        void limpiar()
        {
            txtusuario.Text = string.Empty;
            txtclave.Text = string.Empty;
        }

        private async void bntIngreso_Clicked(object sender, EventArgs e)
        {

            string usuario  = txtusuario.Text;
            string clave = txtclave.Text;
            if (txtusuario.Text == "estudiante2020" && txtclave.Text == "uisrael2020")
            {
                await DisplayAlert("Acceso Correcto", errorMessage, "OK");
              

            }
            else
            {
                await DisplayAlert("Usuario o Contraseña Incorrecta", errorMessage, "OK");
                await Navigation.PushAsync(new MainPage());
                limpiar();

            }
        }
    }
}
