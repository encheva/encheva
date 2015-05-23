using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21};
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }

        }
    }
}
