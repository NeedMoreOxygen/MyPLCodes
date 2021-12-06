using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = 0;
            for(int i = 100; i <= 500; i++)
            {
                res += i;
            }
            Console.WriteLine("Сумма всех чисел от 100 до 500: " + res);
            Console.ReadKey();
        }
    }
}
