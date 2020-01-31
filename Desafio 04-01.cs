using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("TARIFAS DE LA CAJA DE COMPENSACIÓN");
            Console.WriteLine("Responda solo a las preguntas con SI(S) o NO(N)");
            Console.WriteLine("Para conocer su tarifa, por favor responda: ");
            Console.WriteLine("¿Gana usted menos de 2 SMMLV?");
            string p1 = Console.ReadLine();


            if (p1 == "S")
            {
                Console.WriteLine("Su tarifa asignada es la #1");

            }
            else if (p1 == "N")
            {
                Console.WriteLine("¿Gana usted de 2 a 4 SMMLV?");
                string p2 = Console.ReadLine();
                if (p2 == "S")
                {
                    Console.WriteLine("Su tarifa asignada es la #2");

                }
                else
                {
                    Console.WriteLine("Su tarifa asignada es la #3");
                }
            }
            else
            {
                Console.WriteLine("Respuesta inválida :/");
            }
        
        }
        
    }
}
