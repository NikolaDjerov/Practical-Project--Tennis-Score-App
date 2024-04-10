using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations_with_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] start = Console.ReadLine().Split();
            if (start.Length == 2)
            {
                string string1 = start[0];
                string string2 = start[1];
                int sum = 0;
                if (string1.Length != string2.Length)
                {
                    int length = Math.Min(string1.Length, string2.Length);
                    for (int i = 0; i < length; i++)
                    {
                        sum += (int)string1[i] + (int)string2[i];
                    }
                    if (string1.Length > string2.Length)
                    {
                        for (int i = length; i < string1.Length; i++)
                        {
                            sum += (int)string1[i];
                        }
                    }
                    else
                    {
                        for (int i = length; i < string2.Length; i++)
                        {
                            sum += (int)string2[i];
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < string1.Length; i++)
                    {
                        sum += (int)string1[i] * (int)string2[i];
                    }
                }
                Console.WriteLine(sum);
            }
            else
            {
            }
        }
    }
}
