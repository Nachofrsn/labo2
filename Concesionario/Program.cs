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
            Ciudad SanNicolas = new Ciudad("San Nicolas", "Buenos Aires");
            Cliente A = new Cliente("20.43564782.5","Cordero","Ignacio","Italia 500",4456032,SanNicolas);
            A.MostrarCliente();
            Console.ReadKey();
        }
    }
}
