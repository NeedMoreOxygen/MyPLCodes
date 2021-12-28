using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayHW
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            double[] arr = new double[100];
            for (int i = 0; i < 100; i++)
            {
                arr[i] = Math.Round(r.NextDouble() * 100, 1, MidpointRounding.AwayFromZero);
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine("\n");
            double max = arr.Max();
            for (int i = 0; i < 100; i++)
            {
                arr[i] = Math.Round((arr[i] / max), 1, MidpointRounding.AwayFromZero);
                Console.Write($"{arr[i]} ");
            }
            Console.ReadKey();
        }
    }
}