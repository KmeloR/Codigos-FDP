using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BLACK JACK");
            Random cartas = new Random();
            int c1 = 0, c2 = 0, total = 0, c = 0;
            c1 = cartas.Next(1, 10);
            c2 = cartas.Next(1, 10);
            int x = 21;
            total = c1 + c2;
            Console.WriteLine("carta 1: " + c1 + " carta 2: " + c2);
            Console.WriteLine("total = " + total);
            Console.WriteLine("presiona c para continuar");
            Console.WriteLine("para abandonar, presione cualquier otra tecla");
            string continuar = Console.ReadLine();
            while (continuar == "c" && total <= 21)
            {
                c = cartas.Next(1, 10);
                Console.WriteLine("carta: " + c);
                total += c;

                if (x < total)
                {
                    Console.WriteLine("total = " + total);
                    Console.WriteLine("PERDISTE");
                    Console.WriteLine("para abandonar, presione cualquier otra tecla");
                    continuar = null;
                }
                else if (total == x)
                {
                    Console.WriteLine("total = " + total);
                    Console.WriteLine("¡BLACK JACK!");
                    Console.WriteLine("Gracias por jugar");
                    Console.WriteLine("para abandonar, presione cualquier otra tecla");
                    continuar = null;
                }
                else
                {
                    Console.WriteLine("total = " + total);
                    Console.WriteLine("presiona c continuar");
                    Console.WriteLine("para abandonar, presione cualquier otra tecla");
                    continuar = Console.ReadLine();
                }
            }

            Console.ReadKey();


        }
    }
}
