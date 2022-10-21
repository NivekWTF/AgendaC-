using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda
{
    public class Agenda
    {
        private string Nombre;
        private string Telefono;

        public Agenda(string nombre, string telefono)
        {
            Nombre = nombre;
            Telefono = telefono;
        }

        public string pNombre
        {
            get
            {
                return Nombre;
            }
        }
        public string pTelefono
        {
            get
            {
                return Telefono;
            }
        }
    }
}
