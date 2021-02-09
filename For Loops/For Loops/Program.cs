using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            for (var i = 10; i >= 1; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            string name = "John Smith";
            for (var i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            foreach (char character in name)
            {
                Console.WriteLine(character);
            }

            var numbers = new int[4] { 1, 2, 3, 4 };

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
