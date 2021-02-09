using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // You can set i = to b because b is a byte and i is an int.
            // There will not be any data loss because a byte is smaller than an int
            byte b = 1;
            int i = b;
            Console.WriteLine(i);

            // Without type casting, this would give an error during compilation
            int j = 1;
            byte k = (byte) j;
            Console.WriteLine(k);

            // This shows the effect of an int with a number range bigger than a byte
            // and casting the int to byte
            int z = 1000;
            byte x = (byte) z;
            Console.WriteLine(x); // -> 232. Because of the cast, some of the bits were lost

            string number = "1234";
            int w = Convert.ToInt32(number);
            Console.WriteLine(w); // Converts to int because it is within the range of an int
            try
            {
                byte q = Convert.ToByte(number);
                Console.WriteLine(q); // Throws an exception 'System.OverflowException'
                // Value too big or small for unsigned byte
            }
            catch (Exception)
            {
                Console.WriteLine("The number couldn't be converted to byte.");
            }

            try
            {
                string str = "true";
                bool boo = Convert.ToBoolean(str);
                Console.WriteLine(boo);
            }
            catch (Exception)
            {
                Console.WriteLine("The b")
            }
        }
    }
}
