using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_5_Conditions_and_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a symbol, that represents a valid card:");
            string symbol = Console.ReadLine();
            symbol = symbol.ToUpper();

            switch (symbol)
            {
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "10":
                case "J":
                case "Q":
                case "K":
                case "A":

                Console.WriteLine("You have entered a valid card");
                break;
                default:
                Console.WriteLine("There is no such card");
                break;
            }
        }
    }
}
