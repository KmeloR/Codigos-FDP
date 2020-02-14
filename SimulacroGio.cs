using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("BIENVENIDO AL JUEGO");
            Random dados = new Random();
            int d1 = 0, d2 = 0, total = 0, c = 0, i = 1, d = 0;
            Console.WriteLine("presione a para lanzar dados; si desea salir, presione cualquier otra tecla");
            string respuesta = Console.ReadLine();
            while (respuesta == "a" && total <= 100)
            {
                i++;
                d1 = dados.Next(1, 6);
                d2 = dados.Next(1, 6);
                
                total += d1 + d2;
                int suma = d1 + d2;


                if (suma >= 6) c++;
                if (d1 != d2) d = 0;
                else if (d1 == d2 && d1 != 1) d++;
                if (d == 3)
                {
                    Console.WriteLine("HAS GANADO");
                    respuesta = null;
                }
                Console.WriteLine("dado 1: " + d1 + " dado 2: " + d2 + "total: " + total);
                if (d1 == 1 && d2 == 1)
                { Console.WriteLine("HAS PERDIDO");
                    respuesta = null;
                }
                else if (total >= 100)
                {
                    Console.WriteLine("HAS GANADO");
                    respuesta = null;
                }
                else
                {
                    Console.WriteLine("presione a para lanzar dados; si desea salir, presione cualquier otra tecla");
                    respuesta = Console.ReadLine();
                }
                double porcentaje = (((double)c) / i) * 100;

                Console.WriteLine("porcentaje = " + porcentaje);
                Console.WriteLine("dobles: " + d);


            }
        }
    }
}
