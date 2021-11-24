using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите третье число: ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"a) {(a < b & b < c)}\nб) {(b > a & a > c)}");
            Console.ReadKey();
        }
    }
}
