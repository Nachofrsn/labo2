using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpLab2
{
    public class ObjetosCreados
    {
        public static void CreacionObjetos(ref List<Barco> barcos, ref List<Cliente> clientes)
        {
            Barco A = new Barco(50, 10, 15, "Beijing", "15 / 5 / 23", "7 / 6 / 06");
            Barco B = new Barco(40, 8, 10, "Tokyo", "15 / 5 / 23", "9 / 6 / 23");
            Barco C = new Barco(60, 12, 15, "Seoul", "15 / 5 / 23", "8 / 6 /23");
            Barco D = new Barco(50, 10, 15, "Amsterdam", "15 / 5 / 23", "9 / 6 /23");
            Barco E = new Barco(50, 10, 15, "Madrid", "15 / 5 / 23", "7 / 6 /23");
            Barco F = new Barco(50, 10, 15, "Beijing", "15 / 5 / 23", "9 / 6 /23");
            Barco G = new Barco(50, 10, 15, "Madrid", "15 / 5 / 23", "7 / 6 /23");
            Barco H = new Barco(50, 10, 15, "Amsterdam", "15 / 5 / 23", "8 / 6 /23");
            Barco I = new Barco(50, 10, 15, "Tokyo", "15 / 5 / 23", "7 / 6 /23");
            Barco J = new Barco(50, 10, 15, "Seoul", "15 / 5 / 23", "9 / 6 /23");

            barcos.Add(A);
            barcos.Add(B);
            barcos.Add(C);
            barcos.Add(D);
            barcos.Add(E);
            barcos.Add(F);
            barcos.Add(G);
            barcos.Add(H);
            barcos.Add(I);
            barcos.Add(J);


        }
    }
}
