using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryAndDirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Directory.CreateDirectory(@"c:\temp\folder1");
            //var files = Directory.GetFiles(@"c:\temp\", "*.*", SearchOption.AllDirectories);

            //foreach (var file in files)
            //{
            //    Console.WriteLine(file);
            //}

            var directories = Directory.GetDirectories(@"c:\temp\", "*.*", SearchOption.AllDirectories);

            foreach (var dir in directories)
            {
                Console.WriteLine(dir);
            }

            Directory.Exists("...");

            var dirInfo = new DirectoryInfo("...");
            dirInfo.GetFiles();
            dirInfo.GetDirectories();
        }
    }
}
