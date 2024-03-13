using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maximum_length_of_names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nameLength = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();
            Func<string[], string[]> filter = (string[] integer) =>
            {
                return integer.Where(name => name.Length <= nameLength).ToArray();
            };
            string[] print = filter(names);
            foreach(string equalLength in print)
            {
                Console.WriteLine(equalLength);
            }
        }
    }
}
