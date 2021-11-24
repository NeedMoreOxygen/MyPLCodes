using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите название месяца на русском языке: ");
            string s = Console.ReadLine();
            switch (s)
            {
                case "Январь":
                    Console.WriteLine("31");
                    break;
                case "Февраль":
                    Console.WriteLine("28");
                    break;
                case "Март":
                    Console.WriteLine("31");
                    break;
                case "Апрель":
                    Console.WriteLine("30");
                    break;
                case "Май":
                    Console.WriteLine("31");
                    break;
                case "Июнь":
                    Console.WriteLine("30");
                    break;
                case "Июль":
                    Console.WriteLine("31");
                    break;
                case "Август":
                    Console.WriteLine("31");
                    break;
                case "Сентябрь":
                    Console.WriteLine("30");
                    break;
                case "Октябрь":
                    Console.WriteLine("31");
                    break;
                case "Ноябрь":
                    Console.WriteLine("30");
                    break;
                case "Декабрь":
                    Console.WriteLine("31");
                    break;
            }
            Console.ReadKey();
        }
    }
}
