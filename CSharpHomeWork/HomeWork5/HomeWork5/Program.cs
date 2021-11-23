using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    class Program
    {
        static bool voteElligibility(int age)
        {
            return age >= 18;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter The Person's age: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(voteElligibility(a));
            Console.ReadKey();
        }
    }
}
