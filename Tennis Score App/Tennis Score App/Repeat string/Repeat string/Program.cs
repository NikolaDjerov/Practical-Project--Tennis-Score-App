using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeat_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            StringBuilder result = new StringBuilder();
            foreach (string word in words)
            {
                int count = words.Length;
                for (int i = 0; i < count; i++)
                {
                    result.Append(word);
                }
            }
        }
    }
}
