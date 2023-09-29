using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ObjetosLab
{
    public abstract class Ficha
    {
        private string _color;
        private string _tipo;
        private string _seleccionado;
        private string _movimiento;
        private List<Ficha> _listaFicha;

        public Ficha()
        {
            this.Color = "";
            this.Tipo = "";
            this.Seleccionado = "";
            this.Movimiento = "";
            this._listaFicha = new List<Ficha>();
        }
        public Ficha(string color, string tipo, string seleccionado, string movimiento)
        {
            this.Color = color;
            this.Tipo = tipo;
            this.Seleccionado = seleccionado;
            this.Movimiento = movimiento;
            this._listaFicha = new List<Ficha>();
        }
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }
        public string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
        public string Seleccionado
        {
            get { return _seleccionado;}
            set { _seleccionado = value;}
        }
        public string Movimiento
        {
            get { return _movimiento;}
            set { _movimiento = value;}
        }
    }
}
