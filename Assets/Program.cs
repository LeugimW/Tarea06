using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio1_Ramos_Miguel
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            string str;

            bool loopJuegos = true;


            while (loop)
            {
                while (loopJuegos)
                {
                    Console.WriteLine("Juegos de Mesa");
                    Console.WriteLine("1 - Monopolio S/.55");
                    Console.WriteLine("2 - Jenga S/.31");
                    Console.WriteLine("3 - Twister S/.79");

                    str = Console.ReadLine();
                    switch (str)
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine("Monopolio");
                            Console.WriteLine("Este juego es para 3 a 4 Jugadores máximos");
                            break;

                        case "2":
                            Console.Clear();
                            Console.WriteLine("Jenga");
                            Console.WriteLine("Este juego es para 2 a 8 Jugadores máximos");
                            break;

                        case "3":
                            Console.Clear();
                            Console.WriteLine("Twister");
                            Console.WriteLine("Este juego es para 3 a 4 Jugadores máximos");
                            break;

                    }
                    Console.WriteLine("Regresar? (S/N)");
                    str = Console.ReadLine();
                    if (str == "S")
                        loopJuegos = true;
                        Console.Clear();
                    if (str == "N")
                        loopJuegos = false;
               


                    Console.Clear();
                }
            }   
        }
    }
}