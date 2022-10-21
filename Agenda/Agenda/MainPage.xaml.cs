using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Agenda
{
    public partial class MainPage : ContentPage
    {

        List<Agenda> listAgenda = new List<Agenda>();
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnGuardar_Clicked(object sender, EventArgs e)
        {
            string dato1 = txtNombre.Text;
            string dato2 = txtTelefono.Text;
            if (!(dato1 == string.Empty || dato2 == string.Empty))
            {
                string nombre = txtNombre.Text;
                string telefono = txtTelefono.Text;
                listAgenda.Add(new Agenda(nombre, telefono));
                DisplayAlert("Mensaje", "Contacto Guardado.", "Aceptar");
            }
            else
            {
                DisplayAlert("Error", "Dejaste en blanco un campo", "Aceptar");
            }
        }

        private void btnConsultar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PaginaConsulta(listAgenda));
        }
    }
}
