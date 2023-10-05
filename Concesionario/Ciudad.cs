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
        public Ciudad (string ciudad, string provincias)
        {
            Ciudades = ciudad;
            this.Provincias = provincias;
        }
        public string Ciudades
        {
            get { return _ciudad; }
            set { _ciudad = value; }
        }
    }
}
