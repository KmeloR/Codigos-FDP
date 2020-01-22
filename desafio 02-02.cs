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
            Console.WriteLine("CALCULE VALORES DE UN TRIANGULO RECTANGULO");
            Console.WriteLine("ingrese valor a la hipotenusa: ");
            double t = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese valor a un angulo: ");
            double agrados = double.Parse(Console.ReadLine());
            double a = agrados * (Math.PI / 180);
            double y = Math.Sin(a) * t;
            double z = Math.Cos(a) * t;
            double c = 180.0 - 90.0 - agrados;
            Console.WriteLine(" angulo c = " + c + " cateto y = " + y + " cateto z = " + z);
        }
    }
}
