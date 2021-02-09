using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAndFileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\temp\myfile.txt";
            File.Copy(@"c:\temp\myfile.txt", @"c:\bin\myfile.txt", true);
            if (File.Exists(path))
                File.Delete(path);

            var content = File.ReadAllText(path);

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                //
            }
        }
    }
}
