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
           
            Console.WriteLine("Para conocer su tarifa, por favor responda: ");
            Console.WriteLine("¿Cuánto es su salario?");
            double r = double.Parse(Console.ReadLine());


            if (r < 1755606)
            {
                Console.WriteLine("Tu tarifa es la A");
            }
            else if (1755606 <= r && r < 4389015)
            {
                Console.WriteLine("Tu tarifa es la B");
            }
            else 
            {
                Console.WriteLine("Tu tarifa es la C");
            }
        



           
        
        }
        
    }
}
