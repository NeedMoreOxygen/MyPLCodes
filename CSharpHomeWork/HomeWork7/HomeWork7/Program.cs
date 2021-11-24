using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
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
            a = (a > 0) ? Math.Pow(a, 2) : a;
            b = (b > 0) ? Math.Pow(b, 2) : b;
            c = (c > 0) ? Math.Pow(c, 2) : c;
            Console.WriteLine($"A: {a}\nB: {b}\nC: {c}");
            Console.ReadKey();
        }
    }
}
