using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypesVSValueTypes
{
    public class Person
    {
        public int Age;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Part One
            // Value types
            int a = 10;
            int b = a;
            b++;
            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

            // When you copy a value type to a different variable
            // a copy of that value is taken and stored in the target variable
            // that's why they are called value types, their values are copied.

            // Reference types
            int[] array1 = new int[3] { 1, 2, 3 };
            int[] array2 = array1;
            array2[0] = 0;
            Console.WriteLine(string.Format("array[0]: {0}, array2[0]: {1}", array1[0], array2[0]));


            // Part Two
            int number = 1;
            Console.WriteLine(number); // 1
            Increment(number);
            Console.WriteLine(number); // 1
            // the number changed in the Increment method is in a different location
            // in memory (the argument is a copy of the variable), 
            //so the number variable in Main remains 1

            Person person = new Person() { Age = 20 };
            Console.WriteLine(person.Age); // 20
            MakeOld(person);
            Console.WriteLine(person.Age); // 30
            // since the variable person is a reference type,
            // the variable isn't copied, it's memor
        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}
