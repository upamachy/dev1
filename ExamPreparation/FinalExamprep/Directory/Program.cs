using System;
using System.IO;

namespace Directories
{
    class Program
    {
        static void Main(string[] args)
        {
            var files=Directory.GetFiles("files/");
            foreach (var item in files)
            {
                Console.WriteLine(item);
            }
        }
    }
}
