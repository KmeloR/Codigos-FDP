using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("BIENVENIDO AL JUEGO");
            Random dado = new Random();
            int vidas = 3, unos = 0,  especial = 0, d1 = 0, puntos = 0, i = 1;
            Console.WriteLine("PRESIONE N PARA JUGAR, PRESIONE OTRA TECLA PARA SALIR");
            string jugar = Console.ReadLine();
            bool condicion6 =false;
            while (jugar == "N" && puntos <= 100)
            {
                if (especial < 2)
                {
                    Console.WriteLine("TIENES DADO(S) ESPECIALES, ¿DESEAS USAR UNO) S/N");
                    string respuesta = Console.ReadLine();
                    if (respuesta == "S")
                    {
                        i++;
                        d1 = dado.Next(1, 13);
                        especial += 1;
                        puntos += d1;

                        Console.WriteLine("dado = " + d1 + " puntos = " + puntos + " vidas= " + vidas);
                    }
                    else
                    {
                        i++;
                        d1 = dado.Next(1, 7);
                        puntos += d1;
                        if (d1 == 1) unos += 1;
                        if (unos == 2)
                        {
                            vidas -= 1;
                            unos = 0;
                        }
                        Console.WriteLine("dado = " + d1 + " puntos = " + puntos + " vidas= " + vidas);
                    }
                }
                else
                {
                    i++;
                    d1 = dado.Next(1, 7);
                    puntos += d1;
                    if (d1 == 1) unos += 1;
                    if (unos == 2)
                    {
                        vidas -= 1;
                        unos = 0;
                    }
                    Console.WriteLine("dado = " + d1 + " puntos = " + puntos + " vidas= " + vidas);
                }
          
               
                if (d1 == 6) condicion6 = true;
                else if (d1 != 6 && condicion6) condicion6 = false;
                if (condicion6 == true && d1 == 6 && vidas < 3) vidas += 1;
                if (vidas == 0)
                {
                    Console.WriteLine("HAZ PERDIDO");
                    jugar = null;
                }
                else if (puntos >= 100)
                {
                    Console.WriteLine("HAZ GANADO");
                    jugar = null;
                }
                else
                {
                    Console.WriteLine("PRESIONE N PARA JUGAR, PRESIONE OTRA TECLA PARA SALIR");
                    jugar = Console.ReadLine();
                }


            }
        }
    }
}
