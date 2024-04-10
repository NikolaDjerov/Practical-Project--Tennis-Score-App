using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            while(line != "end")
            {
                string reversed = "";
                for(int i = line.Length - 1; i >= 0; i--)
                    reversed += line[i];
                Console.WriteLine($"{line} = {reversed}");
                line = Console.ReadLine();
            }
        }
    }
}
