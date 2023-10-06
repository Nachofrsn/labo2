using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario
{
    class Ciudad : Provincia
    {
        private string _ciudad;
        private Provincia _provincia;
        public Ciudad(string ciudad, Provincia provincia)
        {
            Ciudades = ciudad;
            Provincia = provincia;
        }

        public Provincia Provincia
        {
            get { return _provincia; }
            set { _provincia = value; }
        }

        public string Ciudades
        {
            get { return _ciudad; }
            set { _ciudad = value; }
        }
    }
}
