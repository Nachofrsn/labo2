using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario
{
    public abstract class Marca
    {
        private string _nombreMarca;
        public string NombreMarca
        {
            get { return _nombreMarca; }
            set { _nombreMarca = value; }
        }
    }
}
