using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concatenation_vs_StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();

            StringBuilder text = new StringBuilder();

            for (int i = 0; i < 200000; i++)

                text.Append(i);

            sw.Stop();

            Console.WriteLine(sw.ElapsedMilliseconds);
        }
    }
}
