using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_5_Conditions_and_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer:");
            int numInt = int.Parse(Console.ReadLine());
            if (numInt == 3)
            {
                Console.WriteLine("The number is 9");
            }
            if (numInt == 5)
            {
                Console.WriteLine("The number is 50");
            }
            if (numInt == 9)
            {
                Console.WriteLine(450);
            }
        }
    }
}
