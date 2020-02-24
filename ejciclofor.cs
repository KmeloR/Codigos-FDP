using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("hallar valor de e");
            Console.WriteLine("ingrese valor de x");
            double x = double.Parse(Console.ReadLine());
            int n = 1000;
            double resultados1 = 0, resultados2 = 0, anterior1 = 0, anterior2 = 0;
            for (int i = 0; i < n; i++)
            {
                double e = Math.Pow(x, i)/Factorial(i);
                resultados1 += e;
                if (anterior1 == resultados1) break;
                Console.WriteLine("e = " + resultados1);
                anterior1 = resultados1;
            }
            for(int j = 0;j <n; j++)
            {
                double sinx = (Math.Pow(-1, j) / Factorial((2 * j) + 1)) * Math.Pow(x, ((2 * j) + 1));
                resultados2 += sinx;
                if (anterior2 == resultados2) break;
                Console.WriteLine("sinx = " + resultados2);
                anterior2 = resultados2;
            }
            
        }
        public static double Factorial(double number)
        {
            if (number == 0) return 1;
            if (number == 1) return 1;
            else return number * Factorial(number - 1);
        }
    }
}
