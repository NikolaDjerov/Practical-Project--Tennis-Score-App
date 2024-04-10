using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Calculations = Console.ReadLine().Split();
            int result = 0;
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            foreach (string calculation in Calculations)
            {
                int calcnum = getNums(calculation);
                if (calculation[0] == calculation.ToLower()[0])
                {
                    alphabet.IndexOf(calculation[0]);
                }
                else
                {
                    calcnum /= alphabet.IndexOf(calculation[0]);
                }
                if (calculation[calculation.Length  -1] == calculation.ToLower()[calculation.Length - 1])
                {
                    calcnum += alphabet.IndexOf(calculation[calculation.Length - 1]);
                }
                else
                {
                    calcnum -= alphabet.IndexOf(calculation[calculation.Length - 1]);
                }
                result += calcnum;
                Console.WriteLine($"")
            }
        }
        static int getNums(string calculation)
        {
            int result = 0;
            foreach(char c in calculation)
            {
                if (char.IsDigit(c))
                {
                    result += c;
                }
            }
            return result;
        }
    }
}
