using System;

namespace VariablesConstants
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A'; // chars use single quotes
            string firstName = "Chris";
            bool isWorking = true;

            var count2 = 20; // var keyword - .NET decides what type the variable is. Any integral numbers default to int (integer)

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            Console.WriteLine(count2);

            // prints range of specified primitive type
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            const float Pi = 3.14f;
            // Pi = 1; - won't compile
            

        }
    }
}
