using System;
using System.IO;

namespace WorkingWithFilesExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\temp\myfile.txt";
            Console.WriteLine("Number of words in myfile.txt: " + ExerciseOne(path));
            Console.WriteLine("Longest word in myfile.txt: " + ExerciseTwo(path));
        }

        static int ExerciseOne(string path)
        {
            var file = File.ReadAllText(path);
            var arr = file.Split(' ');
            return arr.Length;
        }

        static string ExerciseTwo(string path)
        {
            string file = File.ReadAllText(path);
            char[] charsToTrim = { ',', '.', ' ' };
            string[] words = file.Split();
            int longestWord = 0;
            string result = "";
            foreach (string word in words)
            {
                string trimmedWord = word.TrimEnd(charsToTrim);
                if (trimmedWord.Length > longestWord)
                    result = trimmedWord;
                    
            }
            return result;
        }
    }
}
