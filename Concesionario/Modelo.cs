using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario
{
    public abstract class Modelo 
    {
        private string _nombreModelo;
        public string NombreModelo
        {
            get { return _nombreModelo; }
            set { _nombreModelo = value; }
        }
    }
}
