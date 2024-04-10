using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Treasures
{
    internal class Treasures
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex regexMetal = new Regex(@"@(\w+)\|");
            Regex regexGem = new Regex(@"#(\w+)\*");
            Match matchMetal = regexMetal.Match(input);
            Match matchGem = regexGem.Match(input);
            string metal = " ";
            string gem = " ";
            if (matchMetal.Success)
            {
                metal = matchMetal.Groups[1].Value;
            }
            if (matchGem.Success)
            {
                gem = matchGem.Groups[1].Value;
            }
            Console.WriteLine($"Found hidden {metal} and {gem} in the cave.");
        }
    }
}
