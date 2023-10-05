using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario
{
    public abstract class Provincia
    {
        private string _provincia;
        private List<Ciudad> _listaCiudad;

        public string Provincias
        {
            get { return _provincia; }
            set { _provincia = value; }
        }
    }
}
