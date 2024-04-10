using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] file = Console.ReadLine().Split('\\');
            string[] lines = file[file.Length - 1].Split(',');

            string fileName = lines[0];
            string extension = lines[1];
            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
