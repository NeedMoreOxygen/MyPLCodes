using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class Program
    {
        static bool isEven(int a)
        {
            return a % 2 == 0;

        }
        static void Main(string[] args)
        {
            Console.Write("Enter The Number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(isEven(a));
            Console.ReadKey();
        }
    }
}
