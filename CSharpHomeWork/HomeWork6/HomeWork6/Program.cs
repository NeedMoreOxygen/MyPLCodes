using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    class Program
    {
        static double sumOfTwo(double a, double b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter The First Number: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter The Second Number: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(sumOfTwo(a, b));
            Console.ReadKey();
        }
    }
}
