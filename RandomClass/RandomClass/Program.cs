using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomClass
{
    class Program
    {
        static void Main(string[] args)
        {
            const int passwordLength = 10;
            var random = new Random();

            for (var i = 0; i < passwordLength; i++)
                Console.Write((char) ('a' + random.Next(0, 26)));
            Console.WriteLine();
            // Console.WriteLine((int) 'a'); // 97
            // 97 is the number for 'a' on the ASCII table

            char[] buffer = new char[passwordLength];
            for (int i = 0; i < passwordLength; i++)
                buffer[i] = (char)('a' + random.Next(0, 26));

            string password = new string(buffer);

            Console.WriteLine(password);
        }
    }
}
