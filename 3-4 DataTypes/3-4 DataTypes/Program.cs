using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_4_DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете стойността на страната на триъгълника");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Въведете стойността на височината на триъгълника");
            int h = int.Parse(Console.ReadLine());

            int s = (a * h) / 2;

            Console.WriteLine("Лицето на вашия триъгълник е:" );
            Console.WriteLine(s);
        }
    }
}
