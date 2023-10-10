using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpLab2
{
    public class ObjetosCreados
    {
        public static void CreacionObjetos(ref List<Barco> barcos, ref List<Cliente> clientes, ref List<Contenedor> contenedores)
        {
            Barco A = new Barco(50, 10, 15, "Beijing", "15 / 5 / 23", "7 / 6 / 06");
            Barco B = new Barco(40, 8, 10, "Tokyo", "15 / 5 / 23", "9 / 6 / 23");
            Barco C = new Barco(60, 12, 15, "Seoul", "15 / 5 / 23", "8 / 6 /23");
            Barco D = new Barco(50, 10, 15, "Amsterdam", "15 / 5 / 23", "9 / 6 /23");
            Barco E = new Barco(50, 10, 15, "Madrid", "15 / 5 / 23", "7 / 6 /23");

            barcos.Add(A);
            barcos.Add(B);
            barcos.Add(C);
            barcos.Add(D);
            barcos.Add(E);
            

            Contenedor contenedor1 = new Contenedor(20, 20, 30);
            Contenedor contenedor2 = new Contenedor(10, 10, 20);
            Contenedor contenedor3 = new Contenedor(15, 20, 30);
            Contenedor contenedor4 = new Contenedor(18, 22, 28);
            Contenedor contenedor5 = new Contenedor(14, 23, 32);
            Contenedor contenedor6 = new Contenedor(11, 15, 22);
            Contenedor contenedor7 = new Contenedor(17, 27, 35);
            Contenedor contenedor8 = new Contenedor(18, 19, 20);

            contenedores.Add(contenedor1);
            contenedores.Add(contenedor2);
            contenedores.Add(contenedor3);
            contenedores.Add(contenedor4);
            contenedores.Add(contenedor5);
            contenedores.Add(contenedor6);
            contenedores.Add(contenedor7);
            contenedores.Add(contenedor8);

            //PREGUNTAR SI CADA CLIENTE NECESITA UNA LISTA DE CONTENEDORES (EL EJERCICIO DICE QUE EL CLIENTE PUEDE TENER MAS DE UN CONTENEDOR)
            Cliente Marcos = new Cliente("Marcos","Peluches","Bodega",7);
            Marcos.AgregarContenedor(contenedor1);
            Marcos.AgregarContenedor(contenedor2);

            Cliente Ignacio = new Cliente("Ignacio","Celulares","Contenedor",10);
            Ignacio.AgregarContenedor(contenedor3);

            Cliente Ezequiel = new Cliente("Ezequiel","Tablet","Contenedor",2);
            Ezequiel.AgregarContenedor(contenedor4);
            Ezequiel.AgregarContenedor(contenedor5);

            Cliente Sofia = new Cliente("Sofia", "Monitor", "Contenedor", 2);
            Sofia.AgregarContenedor(contenedor6);

            Cliente Agustina = new Cliente("Agustina", "Notebook", "Contenedor", 4);
            Agustina.AgregarContenedor(contenedor7);
            Agustina.AgregarContenedor(contenedor8);

            clientes.Add(Marcos);
            clientes.Add(Ignacio);
            clientes.Add(Ezequiel);
            clientes.Add(Sofia);
            clientes.Add(Agustina);
        }
    }
}
