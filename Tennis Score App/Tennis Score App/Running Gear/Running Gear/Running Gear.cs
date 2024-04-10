using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Running_Gear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> fullGear = new List<string>();
            double fullPrice = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Run!")
                {
                    break;
                }
                Regex startPrice = new Regex(@"<>(?<name>[\w]+)<>(?<quantity>[\d]+)--(?<price>[\d]+.[\d]+)");
                MatchCollection calculation = startPrice.Matches(input);
                foreach (Match matches in calculation)
                {
                    string name = matches.Groups["name"].Value;
                    double price = double.Parse(matches.Groups["price"].Value);
                    double quantity = double.Parse(matches.Groups["quantity"].Value);
                    fullGear.Add(name);
                    fullPrice += quantity * price;
                }
            }
            Console.WriteLine("Gear bought:");
            foreach (string gear in fullGear)
            {
                Console.WriteLine(gear);
            }
            Console.WriteLine($"Total cost: {fullPrice:f2}");
        }
    }
}
