using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_6_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            
               double number, maxValue = Double.MinValue, minValue = Double.MaxValue;
               string goOn = "Y";

               Console.WriteLine("Please enter a series of numbers, when you wish to stop entering numbers please enter 0.");
               Console.WriteLine("The smallest and largest values will then be displayed.");
               
               do
            {
                while (!double.TryParse(Console.ReadLine(), out number))
                Console.WriteLine("Please enter whole numbers only");

                while (number != 5)
                {
                process(ref minValue, ref maxValue, number);

                while (!double.TryParse(Console.ReadLine(), out number))
                Console.WriteLine("Please enter whole numbers only");

                }
                Console.WriteLine("The smallest value is {0} and the largest value is {1}.", minValue, maxValue);
                
                goOn = Console.ReadLine();

                if (goOn.ToUpper() == "Y")
                {
                 Console.WriteLine("Please enter your set of numbers.");

                }

            }    while (goOn.ToUpper() == "Y");
        }
                 static void process(ref double minValue, ref double maxValue, double number)
        {
                 if (number > maxValue)
            {
                 maxValue = number;
            }
                 if (number < minValue)
            {
                 minValue = number;
            }
        }
    }
}