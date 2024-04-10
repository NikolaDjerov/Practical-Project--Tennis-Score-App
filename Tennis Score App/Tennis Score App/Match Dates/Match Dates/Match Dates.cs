using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Match_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\d?\d-[A-Z][a-z]{2}-\d{4}";
            Console.WriteLine(pattern);
        }
    }
}
