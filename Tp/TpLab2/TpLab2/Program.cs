using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpLab2
{
    public class Program
    {
        public static string[] menu = new string[] { "1-Generar Despacho.", "2-Salir." };
        static void Main(string[] args)
        {
            int FijadoColor = 0, LongitudMenu = 2;
            ConsoleKey key;
            bool OpcionMenuSalir = true;
            do
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Bienvenido al menu: Muevase con las flechas hacia arriba y abajo. Presione enter para seleccionar. \n");
                    for (int MuestraMenu = 0; MuestraMenu < menu.Length; MuestraMenu++)
                    {
                        //SI LAS CONDICIONES SON IGUALES, IMPRIME EL COLOR DEL INDICE EN VERDE
                        if (MuestraMenu == FijadoColor) Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(menu[MuestraMenu]);
                        Console.ResetColor();
                    }
                    //OBTIENE EL SIGUIENTE CARACTER INGRESADO POR EL USUARIO
                    key = Console.ReadKey(true).Key;
                    switch (key)
                    {
                        case ConsoleKey.UpArrow:
                            //CONTADOR QUE HACE QUE CAMBIE EL COLOR CUANDO SE REINICIA EL FOR
                            FijadoColor--;
                            if (FijadoColor < 0) FijadoColor = 0;
                            break;

                        case ConsoleKey.DownArrow:
                            //CONTADOR QUE HACE QUE CAMBIE EL COLOR CUANDO SE REINICIA EL FOR
                            FijadoColor++;
                            if (FijadoColor > LongitudMenu - 1) FijadoColor = LongitudMenu - 1;
                            break;
                    }
                } while (key != ConsoleKey.Enter);

                switch (FijadoColor)
                {
                    case 0:
                        Console.Clear();

                        Random rnd = new Random();
                        Barco A = new Barco(50,10,15,"Beijing","15 / 5 / 23", "7 / 6 / 06");
                        Barco B = new Barco(40, 8, 10, "Tokyo", "15 / 5 / 23", "9 / 6 / 23");
                        Barco C = new Barco(60, 12, 15, "Seoul", "15 / 5 / 23", "8 / 6 /23");
                        Barco D = new Barco(50, 10, 15, "Amsterdam", "15 / 5 / 23", "9 / 6 /23");
                        Barco E = new Barco(50, 10, 15, "Madrid", "15 / 5 / 23", "7 / 6 /23");
                        Barco F = new Barco(50, 10, 15, "Beijing", "15 / 5 / 23", "9 / 6 /23");
                        Barco G = new Barco(50, 10, 15, "Madrid", "15 / 5 / 23", "7 / 6 /23");
                        Barco H = new Barco(50, 10, 15, "Amsterdam", "15 / 5 / 23", "8 / 6 /23");
                        Barco I = new Barco(50, 10, 15, "Tokyo", "15 / 5 / 23", "7 / 6 /23");
                        Barco J = new Barco(50, 10, 15, "Seoul", "15 / 5 / 23", "9 / 6 /23");

                        List<Barco> barcos = new List<Barco>();
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

                        //IMPRIME LOS BARCOS
                        for (int i = 0; i < 10; i++)
                        {
                            Console.WriteLine($"Barco {i+1}:\nPuerto de origen: {barcos[i].Origen}\nPuerto de destino: {barcos[i].Destino}" +
                                $"\nFecha de salida: {barcos[i].HorarioSalida}\nHorario de llegada: {barcos[i].HorarioLlegada}\n----------------------");
                        }

                        Console.WriteLine("\nSeleccione un barco");
                        int seleccion = int.Parse(Console.ReadLine());
                        Despacho despacho1 = new Despacho(barcos[seleccion - 1],rnd.Next(9000, 18000));
                        try
                        {
                            if (ChequeoUsuario() == true)
                            {
                                Console.WriteLine("Cliente encontrado");
                            }
                        }
                        catch (ClienteInexistenteException e)
                        { 
                            Console.WriteLine(e.Message);
                        }


                        OpcionMenuSalir = false;
                        break;

                    case 1:
                        Console.WriteLine("Eligio salir del programa: cerrando...");
                        OpcionMenuSalir = false;
                        break;
                }
            } while (OpcionMenuSalir);

            Console.ReadKey();
        }

        public static bool ChequeoUsuario()
        {
            if (File.Exists(Constantes.FileNameCSV))
            {
                FileStream archivo = new FileStream(Constantes.FileNameCSV,FileMode.Open);
                StreamReader lector = new StreamReader(archivo);
                Console.WriteLine("Ingrese el nombre de un cliente");
                string cliente = Console.ReadLine();

                lector.ReadLine();
                while (lector.EndOfStream == false) 
                {
                    string line = lector.ReadLine();
                    string[] lines = line.Split(',');

                    if (lines[0] == cliente)
                    {
                        return true;
                    }
                }
            lector.Close(); 
            archivo.Close();
            throw new ClienteInexistenteException();
            }
            else return false;
        }
    }
}
