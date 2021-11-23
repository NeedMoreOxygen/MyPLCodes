using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    class Program
    {
        static string voteElligibility(int age)
        {
            if (age >= 18)
                return "Is Elligible";
            else
                return "Is Not Elligible";
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
