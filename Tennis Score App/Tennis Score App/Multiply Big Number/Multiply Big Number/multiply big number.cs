using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();
            int num = int.Parse(num1);
            for(int i = 0; i < 1; i++)
            {
                num *= int.Parse(num2);
            }
            Console.WriteLine(num);
        }
    }
}
