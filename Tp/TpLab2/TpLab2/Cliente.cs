using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpLab2
{
    public abstract class Cliente
    {
        private string _nombre;
        private string _mercaderia;
        private List<Cliente> _listaClientes;
        private List<Contenedor> _listaContainers;
        private string _formaExportacion;
        private int _toneladas;

        /*public Cliente(string nombre, string mercaderia, string formaExportacion,int toneladas)
        {
            NombreCliente = nombre;
            Mercaderia = mercaderia;
            _listaClientes = new List<Cliente>();
            _listaContainers = new List<Contenedor>();
            Exportacion = formaExportacion;
            Toneladas = toneladas;
        }*/
        
        public string NombreCliente
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Mercaderia
        {
            get { return _mercaderia; }
            set { _mercaderia = value;}
        }

        public string Exportacion
        {
            get { return _formaExportacion; }
            set { _formaExportacion = value; }
        }

        public int Toneladas
        {
            get { return _toneladas;}
            set { _toneladas = value;}
        }
    }
}
