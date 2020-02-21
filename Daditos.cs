using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tareadadogio
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("BIENVENDO AL JUEGO");
            int vidas = 3, d1 = 0, d2 = 0, i = 0, t = 0, total = 0;
            Random dados = new Random();
            bool condiciondobles = false;
            Console.WriteLine("Para jugar, presione N. Para abandonar, presione cualquier otra tecla");
            string respuesta = Console.ReadLine();
            while (respuesta == "N" && vidas > 0)
            {
                i++;
                t++;
                d1 = dados.Next(1, 7);
                if (t == 3)
                {
                    d2 = dados.Next(1, 7);
                    total += d1 + d2;
                    t = 0;
                    Console.WriteLine("Dado 1 = " + d1 + " Dado 2 = " + d2 + " total = " + total + " vidas = " + vidas);
                }
                else
                { total += d1;
                Console.WriteLine("Dado 1 = " + d1 +  " total = " + total + " vidas = " + vidas);
                }
            if (d1 == d2) condiciondobles = true;
            else if (d1 != d2) condiciondobles = false;
            if (condiciondobles == true) vidas += 1;
            if (i == 2)
                {
                    vidas -= 1;
                    i = 0;
                }
                    
            if (vidas == 0)
            {
                Console.WriteLine("HAZ PERDIDO");
                respuesta = null;
            }
            else if (total >= 100)
            {
                Console.WriteLine("HAZ GANADO");
                respuesta = null;
            }
            else
            {
                Console.WriteLine("Para jugar, presione N. Para abandonar, presione cualquier otra tecla");
                respuesta = Console.ReadLine();
            }

            }
        }

    }
}
