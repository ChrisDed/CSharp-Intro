using System;
using System.IO;

namespace PathClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\bin\aws-swticher\aws-switcher.sh";

            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);

            Console.WriteLine("Extension: " + Path.GetExtension(path));
            Console.WriteLine("File Name: " + Path.GetFileName(path));
            Console.WriteLine("File Name w/o Extension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path));

        }
    }
}
