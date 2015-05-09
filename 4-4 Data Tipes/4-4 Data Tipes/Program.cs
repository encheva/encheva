using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_4_Data_Tipes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number...");

            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a number...");

            int b = int.Parse(Console.ReadLine());

            int c = a % b;

            Console.WriteLine("Остатъкът от вашето деление е:");

            Console.WriteLine(c);
        }
    }
}
