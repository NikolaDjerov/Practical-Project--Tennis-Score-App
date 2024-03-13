using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_of_Predicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Func<int, int, bool> func = (a, b) => a % b == 0;
            List<int> divisibleNums = new List<int>();
            bool divisible = true;
            for(int i = 1; i <= n; i++)
            {
                divisible = true;
                for(int j = 0; j < arr.Length; j++)
                {
                    if (!func(i, arr[j]))
                    {
                        divisible = false;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                if(divisible == true)
                {
                    divisibleNums.Add(i);
                    Console.WriteLine(string.Join(" ", divisibleNums));
                }
            }
        }
    }
}
