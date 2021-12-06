using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork14
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            try
            {
                Console.WriteLine("A * B: " + Multiple(a, b));
                Console.WriteLine("A / B: " + Division(a, b));
            }
            catch (ArgumentOutOfRangeException intRangeOut)
            {
                Console.WriteLine(intRangeOut.Message);
            }
            catch (DivideByZeroException myZero)
            {
                Console.WriteLine(myZero.Message);
            }
            catch (Exception myEx)
            {
                Console.WriteLine(myEx.Message);
            }
            Console.ReadKey();
        }
        static int Multiple(int a, int b)
        {
            if (a * b > int.MaxValue)
            {
                throw new OverflowException("Значение было недопустимо малым или недопустимо большим для типа \"Int\"");
            }
            else
                return a * b;
        }
        static int Division(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("На нуль делить нельзя!");
            else
                return a / b;
        }
    }
}
