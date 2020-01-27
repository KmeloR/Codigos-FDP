using System;

namespace Desafío_01_04
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("CALCULE EL VALORES MEDIANTE TRIANGULOS");
            Console.WriteLine("INTRODUZCA VALOR DEL LADO Z DEL TRIANGULO 1");
            double z = double.Parse(Console.ReadLine());
            Console.WriteLine("INTRODUZCA VALOR DEL LADO Y DEL TRIANGULO 1");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("INTRODUZCA VALOR DEL ANGULO B DEL TRIANGULO 2");
            double bgrados = double.Parse(Console.ReadLine());

            //CAMBIO A RADIANES
            double b = bgrados * (Math.PI / 180);
            //RESOLUCION
            double a = Math.Atan(y/ z);
            double f = a + b;
            //g = x + y
            double g = z * Math.Tan(f);
            double x = g - y;

            Console.WriteLine("x = " + x);



        }
    }
}
