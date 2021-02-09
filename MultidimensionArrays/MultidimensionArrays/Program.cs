using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultidimensionArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 3, 7, 9, 2, 14, 6 };

            // Length
            Console.WriteLine("Length: " + numbers.Length);

            // IndexOf()
            int index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9: " + index);

            // Clear()
            Array.Clear(numbers, 0, 2); // Sets first 2 elements to 0, null for strings, false for bools
            Console.WriteLine("Effect of Clear()");
            foreach (var n in numbers)
                Console.WriteLine(n);

            // Copy()
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);
            Console.WriteLine("Effect of Copy()");
            foreach (var n in another)
                Console.WriteLine(n); // 0, 0, 9 - because of clear method

            // Sort()
            Array.Sort(numbers);
            Console.WriteLine("Effect of Sort()");
            foreach (var n in numbers)
                Console.WriteLine(n);

            // Reverse()
            Array.Reverse(numbers);
            Console.WriteLine("Effect of Reverse()");
            foreach (var n in numbers)
                Console.WriteLine(n);
        }
    }
}
