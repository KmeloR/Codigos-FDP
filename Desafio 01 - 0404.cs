using System;

namespace Desafio_01___044
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("CALCULE EL VALORES MEDIANTE TRIANGULOS");
            Console.WriteLine("INTRODUZCA VALOR DEL ANGULO C DEL TRIANGULO 1");
            double cgrados = double.Parse(Console.ReadLine());
            Console.WriteLine("INTRODUZCA VALOR DEL LADO T DEL TRIANGULO 1");
            double t = double.Parse(Console.ReadLine());
            Console.WriteLine("INTRODUZCA VALOR DEL LADO W DEL TRIANGULO 2");
            double w = double.Parse(Console.ReadLine());

            //g = x + y
            //f = a + b
            //CAMBIO A RADIANES
            double c = cgrados * (Math.PI / 180);

            //RESOLUCION
            double z = Math.Sin(c) * t;
            double y = Math.Cos(c) * t;
            double f = Math.Acos(z / w);
            double g = Math.Tan(f) * z;
            double x = g - y;
            

            Console.WriteLine(" x = " + x);
        }
    }
}
