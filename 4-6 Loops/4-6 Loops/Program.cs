using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_6_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;

            long factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial = factorial * i;
            }

            int k = 2;

            long factorialm = 1;

            for (int i = 1; i <= k; i++)
            {
                factorialm = factorialm * i;
            }
            Console.WriteLine(factorial / factorialm);
        }
    }
}
