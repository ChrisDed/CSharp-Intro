using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithTextExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ExerciseOne());
            Console.WriteLine(ExerciseTwo());
            Console.WriteLine(ExerciseThree());
            Console.WriteLine(ExerciseFour());
            Console.WriteLine(ExerciseFive());
        }

        static string ExerciseOne()
        {
            Console.Write("Please enter numbers separated by hyphens: ");
            var input = Console.ReadLine();

            var strNumbers = input.Split('-');
            var numbers = new List<int>();

            foreach (var num in strNumbers)
            {
                numbers.Add(Convert.ToInt32(num));
            }

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] != numbers[i - 1] + 1)
                {
                    return "Not Consecutive";
                }
            }
            return "Consecutive";
        }

        static string ExerciseTwo()
        {
            Console.Write("Please enter numbers separated by hyphens: ");
            var input = Console.ReadLine();

            if (String.IsNullOrEmpty(input))
                return "Empty input provided.";

            foreach (var num in input)
            {
                if (num == '-')
                    continue;
                var firstIndex = input.IndexOf(num);
                var lastIndex = input.LastIndexOf(num);
                Console.WriteLine("1st: " + firstIndex);
                Console.WriteLine("2nd: " + lastIndex);
                if (firstIndex != lastIndex)
                    return "Duplicates";
            }

            return "No dupliates";
        }

        static string ExerciseThree()
        {
            Console.Write("Please enter a time value in the 24-hour format: ");
            var input = Console.ReadLine();

            if (DateTime.TryParse(input, out DateTime result))
            {
                Console.WriteLine(result);
                return "Ok";
            }
            else
            {
                Console.WriteLine(result);
                return "Invalid Time";
            }
        }

        static string ExerciseFour()
        {
            Console.Write("Please enter a few words separatd by spaces: ");
            var input = Console.ReadLine();

            var words = input.Split(' ');
            var builder = new StringBuilder();
            foreach (var word in words)
            {
                var upperWord = word.ToUpper();
                var restOfWord = word.Substring(1);
                builder.Append(upperWord[0]);
                builder.Append(restOfWord);
            }
            return builder.ToString();
        }

        static int ExerciseFive()
        {
            Console.WriteLine("Please enter an English word: ");
            var input = Console.ReadLine();

            var counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Equals('a') 
                    || input[i].Equals('e') 
                    || input[i].Equals('o') 
                    || input[i].Equals('u')
                    || input[i].Equals('i'))
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
