using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(" VERIFIQUEMOS QUE NO ERES UN ROBOT");
            int z = 2, k = 0, p = 0, a = 0;
            Random aleatorio = new Random();
            Console.WriteLine("RESUELVE LA SIGUIENTE OPERACIÓN");
            a = aleatorio.Next(1, 11); 
            p = aleatorio.Next(1, 11); 
            k = aleatorio.Next(1, 11);
            Console.WriteLine(k + " + " + p + "*" + a+" = ");
            double s = k + p * a;
            int R = int.Parse(Console.ReadLine());
            while (R !=s && z > 0)
            {
                z--;
                Console.WriteLine("NADA MI PAI, HAGALE DE NUEVO");
                
                a = aleatorio.Next(1, 11);
                p = aleatorio.Next(1, 11);
                k = aleatorio.Next(1, 11);
                Console.WriteLine(k + " + " + p + "*" + a + " = ");
                s = k + p * a;
                R = int.Parse(Console.ReadLine());
                if (z == 0)
                {
                    Console.WriteLine("pinche robot qlero >:v");

                }
            }

            if (z!=0)
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
                    {
                        total += d1;
                        Console.WriteLine("Dado 1 = " + d1 + " total = " + total + " vidas = " + vidas);
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
}
