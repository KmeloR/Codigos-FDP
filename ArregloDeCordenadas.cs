using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main()
        {
           double[] CordsX = { 0, 2, 3, 7 };
            double[] CordsY = { 0, 1, 5, 6 };
            
            double dp1p2 = Math.Sqrt(Math.Pow((CordsX[0] - CordsX[1]), 2) + Math.Pow((CordsY[0] - CordsY[1]), 2)); 
            double dp1p3 = Math.Sqrt(Math.Pow((CordsX[0] - CordsX[2]), 2) + Math.Pow((CordsY[0] - CordsY[2]), 2));
            double dp1p4 = Math.Sqrt(Math.Pow((CordsX[0] - CordsX[3]), 2) + Math.Pow((CordsY[0] - CordsY[3]), 2));
            double dp2p3 = Math.Sqrt(Math.Pow((CordsX[1] - CordsX[2]), 2) + Math.Pow((CordsY[1] - CordsY[2]), 2));
            double dp2p4 = Math.Sqrt(Math.Pow((CordsX[1] - CordsX[3]), 2) + Math.Pow((CordsY[1] - CordsY[3]), 2));
            double dp3p4 = Math.Sqrt(Math.Pow((CordsX[2] - CordsX[3]), 2) + Math.Pow((CordsY[2] - CordsY[3]), 2));
            double Rp3 = 0, Rp4 = 0;

            bool d1 = dp1p2 > dp1p3 && dp1p2 > dp1p4 && dp1p2 > dp2p3 && dp1p2 > dp2p4 && dp1p2 > dp3p4;
            bool d2 = dp1p3 > dp1p2 && dp1p3 > dp1p4 && dp1p3 > dp2p3 && dp1p3 > dp2p4 && dp1p3 > dp3p4;
            bool d3 = dp1p4 > dp1p2 && dp1p4 > dp1p3 && dp1p4 > dp2p3 && dp1p4 > dp2p4 && dp1p4 > dp3p4;
            bool d4 = dp2p3 > dp1p2 && dp2p3 > dp1p3 && dp2p3 > dp1p4 && dp2p3 > dp2p4 && dp2p3 > dp3p4;
            bool d5 = dp2p4 > dp1p2 && dp2p4 > dp1p3 && dp2p4 > dp1p4 && dp2p4 > dp2p3 && dp2p4 > dp3p4;
            bool d6 = dp3p4 > dp1p2 && dp3p4 > dp1p3 && dp3p4 > dp1p4 && dp3p4 > dp2p4 && dp3p4 > dp2p3;

            //colinealidad en p3
            double Rp3x = (CordsX[0] - CordsX[1]) / (CordsX[2] - CordsX[1]);
            double Rp3y = (CordsY[0] - CordsY[1]) / (CordsY[2] - CordsY[1]);
            //colinealidad en p4
            double Rp4x = (CordsX[0] - CordsX[3]) / (CordsX[3] - CordsX[2]);
            double Rp4y = (CordsX[0] - CordsX[3]) / (CordsX[3] - CordsX[2]);
            //colinealidad
            if (Rp3x == Rp3y) Rp3 = Rp3x;
            if (Rp4x == Rp4y) Rp4 = Rp4x;
            if (Rp3 == Rp4) Console.WriteLine("LOS PUNTOS SON COLINEALES");
            else Console.WriteLine("LOS PUNTOS NO SON COLINEALES");
            //Distancia Máxima
            if (d1) Console.WriteLine("dp1p2 es la distancia mayor");
            else if (d2) Console.WriteLine("dp1p3 es la distancia mayor");
            else if (d3) Console.WriteLine("dp1p4 es la distancia mayor");
            else if (d4) Console.WriteLine("dp2p3 es la distancia mayor");
            else if (d5) Console.WriteLine("dp2p4 es la distancia mayor");
            else  Console.WriteLine("dp3p4 es la distancia mayor");


        }
    }
}
