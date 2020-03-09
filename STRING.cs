using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main()
        {
            string frase = "the quick brown fox jumps over the lazy dog";
            frase = frase.ToUpper();
            string[] palabras = frase.Split(' ');
            string salida = "the";
            salida = salida.ToUpper();
            int repeticion = 0;
            for (int i = 0; i < palabras.Length; i++)
            {
                string palabra = palabras[i];
                if(palabra ==salida)
                {
                    Console.WriteLine(palabra + " encontrada en la posición " + ( i+1));
                    repeticion++;
                }
            }
            Console.WriteLine("la palabra se repite " + repeticion + " veces");
        }
        
    }
}
