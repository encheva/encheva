using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_5_Conditions_and_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a month of the Year:");

            int month = int.Parse(Console.ReadLine());

            switch (month)
         {
            case 1:
            Console.WriteLine("January");
            break;
            case 2:
            Console.WriteLine("February");
            break;
            case 3:
            Console.WriteLine("Mart");
            break;
            case 4:
            Console.WriteLine("April");
            break;
          }
       }
    }
}