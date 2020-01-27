using System;

namespace Desafio_01___0403
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("CALCULE EL VALORES MEDIANTE TRIANGULOS");
            Console.WriteLine("INTRODUZCA VALOR DEL ANGULO D DEL TRIANGULO 2");
            double dgrados = double.Parse(Console.ReadLine());
            Console.WriteLine("INTRODUZCA VALOR DEL LADO W DEL TRIANGULO 2");
            double w = double.Parse(Console.ReadLine());
            Console.WriteLine("INTRODUZCA VALOR DEL LADO X DEL TRIANGULO 2");
            double x = double.Parse(Console.ReadLine());

          
            //CAMBIO A RADIANES
          
            double d = dgrados * (Math.PI / 180);


            //RESOLUCION
            double g = Math.Cos(d) * w;
            double y = g - x;

            Console.WriteLine(" y = " + y);

        }
    }
}
