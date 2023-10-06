using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpLab2
{
    public class Cliente
    {
        private string _nombre;
        private string _codigo;

        public Cliente()
        {
            NombreCliente = "";
            CodigoCliente = "";
        }
        public string NombreCliente
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string CodigoCliente
        {
            get { return _codigo; }
            set { _codigo = value; }
        }
    }
}
