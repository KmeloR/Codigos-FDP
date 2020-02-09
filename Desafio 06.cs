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
            Console.WriteLine("Averigüe su salario");
            Console.WriteLine("Introduzca su salario");
            double salario = double.Parse(Console.ReadLine());
            Console.WriteLine("¿que tipo de contrato tiene? Dependiente = 1  Independiente = 2");
            int contrato = int.Parse(Console.ReadLine());

            int smmlv = 877803;
            double Base = salario * 0.4;
            double arl = 0, pension = 0, eps = 0, prima = 0;

            if (Base < smmlv) Base = smmlv;

            switch (contrato)
            {
                case 1:
                    eps = Base * 0.04;
                    pension = Base * 0.04;
                    prima = salario;
                    break;
                case 2:
                    Console.WriteLine("De 1 a 5, ¿Que tan expuesto al riesgo está en su trabajo?");
                    int riesgo = int.Parse(Console.ReadLine());
                    switch (riesgo)
                    {
                        case 1:
                            arl = Base * (0.522 / 100);
                            break;
                        case 2:
                            arl = Base * (1.044 / 100);
                            break;
                        case 3:
                            arl = Base * (2.436 / 100);
                            break;
                        case 4:
                            arl = Base * (4.350 / 100);
                            break;
                        case 5:
                            arl = Base * (6.960 / 100);
                            break;
                        default:
                            Console.WriteLine("RESPUESTA INVÁLIDA");
                            Console.ReadKey();
                            return;


                    }
                 
                    pension = Base * 0.16;
                    eps = Base * 0.125;

                    break;
            }
            double deducciones = arl + eps + pension;
            double sNeto = salario - deducciones;
            double anual = (sNeto * 12) + prima;

            Console.WriteLine("salario neto = " + sNeto + " anual = " + anual);


        }
    }
}
