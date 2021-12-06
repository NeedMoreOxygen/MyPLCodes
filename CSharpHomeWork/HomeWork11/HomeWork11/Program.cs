using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число: ");
            int a = Convert.ToInt32(Console.ReadLine()), res = 0;
            for (int i = a; i <= 500; i++)
            {
                res += i;
            }
            Console.WriteLine("Сумма чисел от " + a + " до 500: " + res);
            Console.ReadKey();
        }
    }
}
