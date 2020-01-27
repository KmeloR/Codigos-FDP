using System;

namespace Desafio_01_042
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("CALCULE EL VALORES MEDIANTE TRIANGULOS");
            Console.WriteLine("INTRODUZCA VALOR DEL ANGULO D DEL TRIANGULO 2");
            double dgrados = double.Parse(Console.ReadLine());
            Console.WriteLine("INTRODUZCA VALOR DEL LADO Y DEL TRIANGULO 1");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("INTRODUZCA VALOR DEL ANGULO B DEL TRIANGULO 2");
            double bgrados = double.Parse(Console.ReadLine());

            double fgrados = 180 - 90 - dgrados;
            //f = b + a

            //CAMBIO A RADIANES
            double b = bgrados * (Math.PI / 180);
            double d = dgrados * (Math.PI / 180);
            double f = fgrados * (Math.PI / 180);

            //RESOLUCION
            double a = f - b;
            double z = y / Math.Tan(a);

            Console.WriteLine(" z = " + z);

        }
    }
}
