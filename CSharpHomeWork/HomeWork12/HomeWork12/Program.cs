using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число: ");
            int b = Convert.ToInt32(Console.ReadLine()), res = 0;
            for(int i = -10; i <= b; i++)
            {
                res += i;
            }
            Console.WriteLine("Сумма целых чисел от -10 до " + b + ": " + res);
            Console.ReadKey();
        }
    }
}
