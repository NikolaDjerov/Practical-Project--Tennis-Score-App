using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex pattern = new Regex(@"%([A-Z][a-z]+)%<([A-Za-z]+)>\|([0-9]+)\|([0-9]+[.][0-9]|[0-9]+)\$");
            double total = 0;

            while (input != "end of shift")
            {
                if (pattern.IsMatch(input))
                {
                    Match match = pattern.Match(input);
                    string name = match.Groups[1].Value;
                    string productName = match.Groups[2].Value;
                    int quantity = int.Parse(match.Groups[3].Value);
                    double price = double.Parse(match.Groups[4].Value);
                    Console.WriteLine($"{name}: {productName} - {quantity * price:f2}");
                    total += quantity * price;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {total:f2}");
        }
    }
}
