using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysListsExercises
{
    class Program
    {
        static void Exercise1()
        {
            var people = new List<string>();
            while (true)
            {
                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                    break;

                people.Add(input);
            }

            if (people.Count == 1)
                Console.WriteLine(String.Format("{0} likes your post.", people[0]));
            else if (people.Count == 2)
                Console.WriteLine(String.Format("{0} and {1} like your post.", people[0], people[1]));
            else
                Console.WriteLine(String.Format("{0}, {1}, and {2} others like your post.", people[0], people[1], people.Count - 2));
        }

        static void Exercise2()
        {
            Console.Write("Please enter your name: ");
            string input = Console.ReadLine();
            char[] reverse = input.ToCharArray();
            Array.Reverse(reverse);
            string result = "";
            foreach (var l in reverse)
                result += l;
            Console.WriteLine(result);
        }

        static void Exercise3()
        {
            Console.WriteLine("Please enter 5 unique numbers");
            List<int> list= new List<int>();
            int counter = 0;
            while (true)
            {
                if (counter > 4)
                    break;

                string input = Console.ReadLine();
                int num = Convert.ToInt32(input);
                if (list.Contains(num))
                {
                    Console.WriteLine("Number already inputted. Retry.");
                    continue;
                }
                list.Add(num);
                counter++;
            }
            list.Sort();
            foreach (var n in list)
                Console.WriteLine(n);
        }

        static void Exercise4()
        {
            List<int> result = new List<int>();
            Console.WriteLine("Enter numbers or type Quit to quit");
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Quit")
                    break;

                int num = Convert.ToInt32(input);
                if (result.Contains(num))
                    result.Remove(num);
                else
                    result.Add(num);
            }
            foreach (var n in result)
                Console.WriteLine(n);
        }

        static void Exercise5()
        {
            while (true)
            {
                List<int> list = SubExercise5();
                if (list.Count < 5)
                {
                    Console.WriteLine("Invalid list, please try again");
                    continue;
                }
                list.Sort();
                Console.WriteLine(list[0]);
                Console.WriteLine(list[1]);
                Console.WriteLine(list[2]);
                break;
            }
        }

        static List<int> SubExercise5()
        {
            Console.WriteLine("Please enter 5 numbers separated by commas");
            string input = Console.ReadLine();
            string[] strNums = input.Split(',');
            List<string> listNums = strNums.ToList<string>();
            listNums.RemoveAll(new Predicate<string>(IdkWhatToCallThis));
            List<int> result = new List<int>();
            foreach (var n in listNums)
            {
                result.Add(Convert.ToInt32(n));
            }
            return result;
        }

        static bool IdkWhatToCallThis(String s)
        {
            return s.ToLower().EndsWith(", ");
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
