using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Agenda
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaConsulta : ContentPage
    {
        List<Agenda> ListAgenda;
        public PaginaConsulta(List<Agenda> la)
        {
            InitializeComponent();
            ListAgenda = la;
            ObtenTotal();
        }

        public void ObtenTotal()
        {
            lblTotal.Text = "Total de Contactos:" + ListAgenda.Count.ToString();
        }
    }
}