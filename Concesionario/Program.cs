using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Provincia BuenosAires = new Provincia();
            BuenosAires.Provincias = "Buenos Aires";
            Ciudad SanNicolas = new Ciudad("San Nicolas");
            Cliente A = new Cliente("20.43564782.5","Cordero","Ignacio","Italia 500",4456032,SanNicolas);
            List<Ciudad> cities = new List<Ciudad>();
            cities.Add(SanNicolas);


            A.MostrarCliente();
            Console.ReadKey();
        }
    }
}
