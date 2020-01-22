using System;
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
            Console.WriteLine("CALCULE VALORES DE UN TRIANGULO RECTANGULO");
            Console.WriteLine("ingrese valor de z: ");
            double z = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese valor de y: ");
            double y = double.Parse(Console.ReadLine());
            double t = Math.Sqrt((z * z) + (y * y));
            double c = Math.Asin(z / t)*(180/Math.PI);
            double a = 180 - 90 - c;

            Console.WriteLine(" t(hipotenusa) = " + t + " angulo c = " + c + " angulo a = " + a);
        }
    }
}
