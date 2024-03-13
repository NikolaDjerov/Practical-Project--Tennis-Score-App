using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naming_sir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] name = Console.ReadLine().Split();
            Action<string[]> output = (a) => Console.WriteLine($"Sir {name}");
        }
    }
}
