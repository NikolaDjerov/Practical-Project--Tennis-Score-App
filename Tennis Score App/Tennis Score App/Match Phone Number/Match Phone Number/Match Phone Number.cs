using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var regex = @"[A-Z][a-z]+ [A-Z][a-z]";
            var phones = Console.ReadLine();
            var phoneMatches = Regex.Matches(phones, regex);
        }
    }
}
