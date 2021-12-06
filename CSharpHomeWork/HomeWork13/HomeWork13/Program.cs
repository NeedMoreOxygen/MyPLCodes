using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine()), res = 0;
            Console.Write("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            for(int i = a; i <= b; i++)
            {
                res += i;
            }
            Console.WriteLine("Сумма целых чисел от " + a + " до " + b + ": " + res);
            Console.ReadKey();
        }
    }
}
