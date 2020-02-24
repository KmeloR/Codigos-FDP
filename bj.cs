﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("BLACK JACK");
            Console.WriteLine("ingrese # de jugadores (2 - 5)");
            int jugadores = int.Parse(Console.ReadLine());
            int jugador = 0, max = 0, ganador = 0;
            while (jugadores < 2 || jugadores > 5)
           
            {
                Console.WriteLine("número de jugadores no permitido. Intente de nuevo");
                jugadores = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n\n BIENVENIDOS, JUGADORES");
            while (jugadores >= 2 && jugadores <= 5)
            {
                Console.WriteLine("\n\n turno: jugador " + (jugador + 1));
                Random cartas = new Random();
                int c1 = 0, c2 = 0, total = 0, c = 0;
                c1 = cartas.Next(1, 11);
                c2 = cartas.Next(1, 11);
                int x = 21;
                total = c1 + c2;
                jugador += 1;
                Console.WriteLine("carta 1: " + c1 + " carta 2: " + c2);
                Console.WriteLine("total = " + total);
                Console.WriteLine("¿Desea continuar?s/n");
                string continuar = Console.ReadLine();
                while (continuar != "s" && continuar != "n")
                {
                    Console.WriteLine("respuesta inválida. Intente de nuevo.");
                    continuar = Console.ReadLine();
                }
                while (continuar == "n") continuar = null;
                while (continuar == "s" && total <= 21)
                {
                    c = cartas.Next(1, 11);
                    Console.WriteLine("carta: " + c);
                    total += c;
                    max += c;
                    if (total > max && total <= 21)
                    {
                        max = total;
                        ganador=jugadores;
                    }
                    if (x < total)
                    {
                        Console.WriteLine("total = " + total);
                        Console.WriteLine("PERDISTE");
                        continuar = null;
                    }
                    else if (total == x)
                    {
                        Console.WriteLine("total = " + total);
                        Console.WriteLine("¡BLACK JACK!");
                        continuar = null;
                    }
                    else
                    {
                        Console.WriteLine("total = " + total);
                        Console.WriteLine("¿Desea continuar?s/n");
                        continuar = Console.ReadLine();
                    }
                }

                
                
                
                if (jugador == jugadores) break;
            }
            Console.WriteLine("GANADOR = JUGADOR " + (ganador+1));
            
        }
    }
}
