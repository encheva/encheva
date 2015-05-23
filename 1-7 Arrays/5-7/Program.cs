using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_7
{
    class Program
    {
        static void Main(string[] args)
        {
                int a = 5;
                int b = 50; 

                for (int c = a; c < b; c++)
            {
                if (c % 3 == 0)
                {
                    Console.WriteLine(c);
                }
            }          
        }
    }
}
