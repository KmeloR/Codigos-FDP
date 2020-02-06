using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("votos partido 1");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("votos partido 2");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("votos en blanco");
            int blancos = int.Parse(Console.ReadLine());
            Console.WriteLine("votos anulados");
            int anulados = int.Parse(Console.ReadLine());
            Console.WriteLine("# de habitantes");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("% de habilitados para votar");
            int p = int.Parse(Console.ReadLine());

            int v = n * (p / 100);
            int total = a + b + blancos + anulados;
            int d = Math.Abs(b - a);

            bool A = total > n;
            bool B = d < (total * 0.1);
            bool C = v < (n * 0.3);

            if (A || B && C) Console.WriteLine("Las votaciones deben repetirse");
            else if (a > b) Console.WriteLine("el partido ganador es partido 1");
            else  Console.WriteLine("el partido ganador es partido 2");
        }
    }
}
