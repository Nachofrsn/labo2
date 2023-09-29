using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ObjetosLab
{
    internal class Tablero
    {
        private int[][] _matriz;
        private string _colorCasilla;

        public Tablero(int [][] matriz, string colorCasilla)
        {
           _matriz = matriz;
           _colorCasilla = colorCasilla;
        }
        public int[][] Matriz
        {
            get { return _matriz; }
            set { _matriz = value; }    
        }
        public string ColorCasilla
        {
            get { return _colorCasilla; }
            set { _colorCasilla = value; }
        }
        //List <Ficha> fichas = new list <Ficha>();
        /*
         * set = 1 valor, list puede tener varios. La lista no garantiza orden.
         * Declarar como abstracta a ficha 
         * Usar bool para seleccionar() y deseleccionar() en ficha.
         */
    }
}
