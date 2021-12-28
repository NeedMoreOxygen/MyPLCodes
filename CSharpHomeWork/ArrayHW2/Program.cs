using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayHW2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int max = 0;
            int min = 0;
            int maxIndex = 0;
            int minIndex = 0;
            int[] arr = new int[100];
            for (int i = 0; i < 100; i++)
            {
                arr[i] = r.Next(0, 100);
                Console.Write($"{arr[i]} ");
            }
            min = arr.Max();
            for(int i = 0; i < 100; i++)
            {
                if(arr[i] > max)
                {
                    max = arr[i];
                    maxIndex = i;
                }
                if(arr[i] < min)
                {
                    min = arr[i];
                    minIndex = i;
                }
            }
            Console.Write("\n\n");
            int temp = arr[maxIndex];
            arr[maxIndex] = arr[minIndex];
            arr[minIndex] = temp;
            for (int i = 0; i < 100; i++)
                Console.Write($"{arr[i]} ");
            Console.ReadKey();
        }
    }
}
