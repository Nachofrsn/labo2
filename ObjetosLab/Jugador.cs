using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ObjetosLab
{
    internal class Jugador
    {
        private string _color;
        private float _puntaje;
        private int _tiempo;
        private string _nombre;
        
        public Jugador (string color, float puntaje, int tiempo, string nombre)
        {
            this.Color = color;
            this.Puntaje = puntaje;
            this.Tiempo = tiempo;
            this.Nombre = nombre;
        }
        public string Color
        {
            get { return this._color; }
            set { this._color = value; }
        }
        public float Puntaje
        {
            get { return this._puntaje; }
            set { this._puntaje = value; }
        }
        public int Tiempo
        {
            get { return this._tiempo; }
            set { this._tiempo = value;}
        }
        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }
    }
}
