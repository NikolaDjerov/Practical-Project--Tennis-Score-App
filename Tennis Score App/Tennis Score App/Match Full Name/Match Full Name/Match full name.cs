using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Match_Full_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string listOfNames = Console.ReadLine();
            string pattern = @"\b([A-Z][a-z]+[A-Z][a-z])";
            Regex regex = new Regex(pattern);
            MatchCollection validName = regex.Matches(pattern);
            foreach (Match name in validName)
            {
                Console.WriteLine(name.Value);
            }
        }
    }
}
