using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int total = 0;
            int cartas = 0;
            int i = 0;
            string continuar = "s";


            Console.WriteLine("Ingrese la cantidad de datos a ingresar: ");
            int n = int.Parse(Console.ReadLine());
            string[] nombres = new string[n];
            int[] puntajes = new int[n];
            int puntajeMaximo = 0, puntajeMinimo = 100, segundo = 0, segundopuntaje = 0;
            string nombreMaximo = "nombre", nombreMinimo = "nombre";
            for (int f = 0; f < n; f++)
            {
                continuar = "s"; //para que me deje continuar con mas jugadores.
                total = 0; // para resetar el puntaje con otros jugadores. 
                Console.WriteLine("ingrese su nombre:");
                nombres[f] = Console.ReadLine();

                while (i < 1)
                {
                    cartas = aleatorio.Next(1, 11);
                    total += cartas;
                    Console.WriteLine("esta fue su carta:" + cartas);
                    Console.WriteLine("esete es su puntaje:" + total);
                    i++;
                }
                while (continuar == "s" && total < 21)
                {
                    cartas = aleatorio.Next(1, 11);
                    total += cartas;
                    Console.WriteLine("esta fue su carta:" + cartas);
                    Console.WriteLine("este es su puntaje:" + total);
                    if (total > 21)
                    {
                        Console.WriteLine("valiste verga, perdiste: " + total + "puntos");
                        total = 0;
                    }
                    else
                    {
                        Console.WriteLine("desea continuar (s/n)");
                        continuar = Console.ReadLine();
                    }

                    puntajes[f] = total; //almacenar puntajes 

                }
                if (total > puntajeMaximo)
                {
                    total = puntajeMaximo;
                    puntajeMaximo = puntajes[f];
                    nombreMaximo = nombres[f];
                }
                if (total < puntajeMinimo)
                {
                    total = puntajeMinimo;
                    puntajeMinimo = puntajes[f];
                    nombreMinimo = nombres[f];
                }
                for (int a = 0; a < n; a++)
                {
                    if (puntajes[a] > segundopuntaje && puntajes[a] < puntajeMaximo)
                    {

                        segundopuntaje = puntajes[a];
                        segundo = a;

                    }
                }


            }
            Console.WriteLine("el jugador con mayor puntaje fue: " + nombreMaximo + ", con" + puntajeMaximo + "...puntos");
            Console.WriteLine("el jugador con segundo mayor puntaje fue: " + nombres[segundo] + ", con" + segundopuntaje + "...puntos");
            Console.WriteLine("el jugador con menor puntaje fue: " + nombreMinimo + ", con" + puntajeMinimo + "...puntos");
        }
    }
}
