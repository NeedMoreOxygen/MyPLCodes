using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayHW3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            double[] A = new double[20];
            int n = 0;
            for (int i = 0; i < 20; i++)
            {
                A[i] = Math.Round(r.NextDouble() * 200 - 100, 1, MidpointRounding.AwayFromZero);
                Console.Write($"{A[i]} ");
                if (A[i] > 0 && i % 2 == 0)
                    ++n;
            }
            double[] B = ;
            int element = 0;
            Console.Write("\n\n");
            for (int i = 0; i < 20; i++)
            {
                if (element == n)
                    break;
                else if (A[i] > 0 && i % 2 == 0)
                {
                    B[element] = A[i];
                    Console.Write($"{B[element]} ");
                    element++;
                }
            }
            Console.ReadKey();
        }
    }
}
