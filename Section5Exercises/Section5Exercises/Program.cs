using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section5Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1
            Console.WriteLine("Please enter a number 1 - 10: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number >= 1 && number <= 10)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");

            // Exercise 2
            Console.WriteLine("Please enter a number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int max = (number1 > number2) ? number1 : number2;
            Console.WriteLine("Max is " + max);

            // Exercise 3
            Console.WriteLine("Please enter a width of an image: ");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a height of an image: ");
            int height = Convert.ToInt32(Console.ReadLine());

            if (height > width)
            {
                Console.WriteLine("Portrait");
            }
            else
            {
                Console.WriteLine("Landscape");
            }

            // Exercise 4
            int demeritPoints = 0;
            Console.WriteLine("Please enter the speed limit");
            int limit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the speed of the car");
            int speed = Convert.ToInt32(Console.ReadLine());
            if (speed <= limit)
            {
                Console.WriteLine("Okay");
            }
            else
            {
                demeritPoints = (speed - limit) / 5;
                if (demeritPoints > 12)
                {
                    Console.WriteLine("License Suspended");
                }
                else
                {
                    Console.WriteLine(string.Format("Number of demerit points: {0}", demeritPoints));
                }
            }
        }
    }
}
