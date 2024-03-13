using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();
            Func<string, int> num = x => x.Select(c => (int)c).Sum();
            Func<string, int, bool> end = (x, score) =>
            {
                return num(x) >= score;
            };
            string output = x.FirstOrDefault(x => end(x, number));
            Console.WriteLine(output);
           
        }
    }
}

