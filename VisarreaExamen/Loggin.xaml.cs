using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace VisarreaExamen
{
    public partial class Loggin : ContentPage
    {
        public Loggin()
        {
            InitializeComponent();
        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;
            if ((usuario == "estudiante2021") && (contraseña == "uisrael2021"))
            {
                await Navigation.PushAsync(new Registro(usuario));
            }
            else
            {
                lblMensaje.Text = "El usuario o contraseña son incorrectos";
            }
        }
    }
}
