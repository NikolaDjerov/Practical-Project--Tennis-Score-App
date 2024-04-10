using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Find_Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] allLines = new string[N];
            for (int i = 0; i < N; i++)
            {
                allLines[i] = Console.ReadLine();
            }
            foreach (string line in allLines)
            {
                int age = line.IndexOf('*', '#');
                int name = line.IndexOf('|', '@');
                if (age != -1 &&  name != -1)
                {
                    string fullName = line.Substring(1 + name, name - name - 1);
                    int fullAge = ' ';
                    if (int.TryParse(line.Substring(1 + age, age - age - 1), out fullAge))
                    {
                        Console.WriteLine($"{fullName} is {fullAge} years old.");
                    }
                }
            }
        }
    }
}