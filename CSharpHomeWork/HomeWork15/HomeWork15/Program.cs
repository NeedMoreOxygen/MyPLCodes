using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork15
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random r = new Random();
            int n = Convert.ToInt32(Console.ReadLine());
            List<double> A = new List<double>();
            try
            {
                for (int i = 0; i < n; i++)
                {
                    A[i] = r.Next(-100, 100);
                    Console.Write(A[i] + " ");
                    if (A[i] > 0 || A[i] % 2 == 0)
                        A[i] = Math.Pow(A[i], 2);
                    else
                        throw new Exception("Число является отрицательным!");
                }
                for (int i = 0; i < n; i++)
                {
                    Console.Write(A[i] + " ");
                }
            }
            catch (Exception myExc)
            {
                Console.WriteLine(myExc.Message);
            }
            Console.ReadKey();
        }
    }
}
