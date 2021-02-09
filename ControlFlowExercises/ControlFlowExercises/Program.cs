using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlowExercises
{
    class Program
    {
        public static void Exercise1()
        {
            int count = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                    count++;
            }
            Console.WriteLine(count);
        }

        public static void Exercise2()
        {
            int sum = 0;
            while(true)
            {
                Console.Write("Enter a number: ");
                var input = Console.ReadLine();
                if (input != "ok")
                {
                    int num = Convert.ToInt32(input);
                    sum += num;
                    continue;
                }
                break;
            }
            Console.WriteLine("Sum of all inputted numbers: " + sum);
        }

        public static void Exercise3()
        {
            Console.Write("Enter a number to calculate the factorial: ");
            int input = Convert.ToInt32(Console.ReadLine());
            int result = 1;
            for (int i = input; i >= 1; i--)
            {
                result = result * i;
            }
            Console.WriteLine(input + "! = " + result);
        }

        public static void Exercise4()
        {
            Random random = new Random();
            int num = random.Next(1,10);
            int counter = 1;
            while(counter < 5)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                if (input != num)
                {
                    counter++;
                }
                else
                {
                    Console.WriteLine("You won!");
                    break;
                }
            }
            if (counter > 4)
                Console.WriteLine("You lost");
        }

        public static void Exercise5()
        {
            string input = Console.ReadLine();
            string[] array1 = input.Split(',');
            int max = 0;
            foreach (var elem in array1)
            {
                int num = Convert.ToInt32(elem);
                if (num > max)
                    max = num;
            }
            Console.WriteLine("The max of inputted numbers is: " + max);
               
        }

        static void Main(string[] args)
        {
            Exercise1();
            Exercise2();
            Exercise3();
            Exercise4();
            Exercise5();
        }
    }
}
