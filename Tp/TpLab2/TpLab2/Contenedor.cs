using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpLab2
{
    public class Contenedor
    {
        private int _alto;
        private int _ancho;
        private int _largo;


        public Contenedor(int largo, int ancho, int alto)
        {
            Largo = largo;
            Ancho = ancho;
            Alto = alto;
        }


        public int TarifaContenedor
        {
            get { return 5000; }
        }

        public int Largo
        {
            get { return _largo; }
            set { _largo = value; }
        }

        public int Ancho
        {
            get { return _ancho; }
            set { _ancho = value; }
        }

        public int Alto
        {
            get { return _alto; }
            set { _alto = value; }
        }

        public int MedidaContainer
        {
            get { return Alto * Ancho * Largo; }
        }
    }
}
