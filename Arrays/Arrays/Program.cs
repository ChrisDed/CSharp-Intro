using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // If an index of an array hasn't been assigned a value
            // it takes the default value for the specified data type
            // e.x. any number defaults to 0, booleans default to false, etc.

            int[] numbers = new int[3];
            numbers[0] = 1;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            bool[] flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            string[] names = new string[3] { "Jack", "John", "Mary" };
        }
    }
}
