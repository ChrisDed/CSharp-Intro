using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 3;

            Console.WriteLine(a + b);

            int z = 10;
            int x = 3;

            Console.WriteLine((float)z / (float)x);

            int c = 3;
            int j = 2;
            int k = 1;

            Console.WriteLine(k + j * c);

            int p = 1;
            int u = 2;

            Console.WriteLine(p > u);
            Console.WriteLine(p >= u);
            Console.WriteLine(p != u);
            Console.WriteLine(!(p != u)); // p != u is true but ! in front makes it false
            // If there are double negatives in your boolean logic
            // Just convert to a single positive to achieve the same result
            Console.WriteLine(p == u);

            var r = 1;
            var q = 2;
            var w = 3;

            Console.WriteLine(w > q && w > r);
            Console.WriteLine(w > q && w == r);
            Console.WriteLine(w > q || w == r);

        }
    }
}
