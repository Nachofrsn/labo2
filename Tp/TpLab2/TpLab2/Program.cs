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

                        Random rnd = new Random(); //PARA EL CODIGO DE DESPACHO

                        List<Barco> barcos = new List<Barco>();
                        List<Cliente> clientes = new List<Cliente>();

                        CreacionObjetos(ref barcos, ref clientes);

                        Console.WriteLine("Barcos disponibles:\n");
                        //IMPRIME LOS BARCOS
                        for (int i = 0; i < 10; i++)
                        {
                            if (barcos[i].Disponibilidad == "Disponible")
                            {
                                Console.WriteLine($"Barco {i + 1}:\nPuerto de origen: {barcos[i].Origen}\nPuerto de destino: {barcos[i].Destino}" +
                                $"\nFecha de salida: {barcos[i].HorarioSalida}\nHorario de llegada: {barcos[i].HorarioLlegada}\n----------------------");
                            }
                        }

                        Console.WriteLine("\nSeleccione un barco");
                        int seleccion = int.Parse(Console.ReadLine());
                        SeleccionBarco(seleccion, ref barcos);
                        Despacho despacho1 = new Despacho(barcos[seleccion - 1], rnd.Next(9000, 18000));

                        try
                        {
                            if (ChequeoUsuario(ref despacho1) == true)
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

        public static bool ChequeoUsuario(ref Despacho despacho1)
        {
            if (File.Exists(Constantes.FileNameCSV))
            {
                FileStream archivo = new FileStream(Constantes.FileNameCSV, FileMode.Open);
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
                        despacho1.NombreCliente = lines[0];
                        despacho1.Mercaderia = lines[1];

                        lector.Close();
                        archivo.Close();
                        return true;
                    }
                }
                lector.Close();
                archivo.Close();
                throw new ClienteInexistenteException();
            }
            else return false;
        }

        public static bool SeleccionBarco(int seleccion, ref List <Barco> barcos)
        {
            if (seleccion > 10 || seleccion < 0 || barcos[seleccion - 1].Disponibilidad != "Disponible")
            {
                return false;
            }
            else return true;
        }
    }
}
