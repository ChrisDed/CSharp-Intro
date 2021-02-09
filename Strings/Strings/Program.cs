using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Chris";
            string lastName = "Dedeian";

            string fullname = firstName + " " + lastName;
            string fullName = string.Format("{0} {1}", firstName, lastName);

            string[] names = new string[3] { "John", "Jack", "Mary" };
            string formattedName = string.Join(",", names);
            Console.WriteLine(formattedName);

            string text = "Hi John\nLook into the following paths\nc:\\folder1\\folder2\nc:\\folder3\\folder4";
            Console.WriteLine(text);

            string newText = @"Hi John
Look into the following paths
c:\folder1\folder2\
c:\folder3\folder4";

            Console.WriteLine(newText);
        }
    }
}
