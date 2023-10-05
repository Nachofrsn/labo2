using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario
{
    public class Provincia
    {
        private string _provincia;
        private List<Ciudad> _listaCiudad;

        public Provincia()
        {
            Provincias = "";
            _listaCiudad = new List<Ciudad>();
        }
        public string Provincias
        {
            get { return _provincia; }
            set { _provincia = value; }
        }
    }
}
