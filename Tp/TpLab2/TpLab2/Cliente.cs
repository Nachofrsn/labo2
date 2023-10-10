using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace TpLab2
{
    public class Cliente
    {
        private string _nombre;
        private string _mercaderia;
        private List<Cliente> _listaClientes;
        private List<Contenedor> _listaContainers;
        private string _formaExportacion;
        private int _toneladas;

        public Cliente(string nombre, string mercaderia, string formaExportacion,int toneladas)
        {
            NombreCliente = nombre;
            Mercaderia = mercaderia;
            _listaClientes = new List<Cliente>();
            _listaContainers = new List<Contenedor>();
            Exportacion = formaExportacion;
            Toneladas = toneladas;
        }
        
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

        public void AgregarContenedor(Contenedor contenedor) 
        {
            _listaContainers.Add(contenedor);
        }

        public void MostrarContenedores()
        {
            int i = 1;
            foreach(Contenedor aux in _listaContainers)
            {
                Console.WriteLine($"Contenedor {i}\nLargo: {aux.Largo}\nAlto: {aux.Alto}\nAncho: {aux.Ancho}\n---------------------");
                i++;
            }
        }
    }
}
