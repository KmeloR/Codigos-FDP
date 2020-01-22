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
            Console.WriteLine("CALCULE VALORES DE UN TRIANGULO RECTANGULO");
            Console.WriteLine("ingrese valor del cateto: ");
            double z = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese valor de un angulo: ");
            double cgrados = double.Parse(Console.ReadLine());
            double c = cgrados * (Math.PI / 180);
            double t = z / Math.Sin(c);
            double y = z / Math.Tan(c);
            double a = 180.0 - 90.0 - cgrados;
            Console.WriteLine("angulo a = " + a + "hipotenusa t = " + t + "cateto y = " + y);
        }
    }
}
