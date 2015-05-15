using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_6_Loops
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

            long factorialk = 1;

            for (int i = 1; i <= k; i++)
            {
                factorialk = factorialk * i;
            }
            int nk = n - k;

            long factorialnk = 1;

            for (int i = 1; i <= nk; i++)
            {
                factorialnk = factorialnk * i;
            }
            Console.WriteLine("N!*K!/(N-K)!=" + ((factorial * factorialk) / factorialnk));
        }
    }
}
