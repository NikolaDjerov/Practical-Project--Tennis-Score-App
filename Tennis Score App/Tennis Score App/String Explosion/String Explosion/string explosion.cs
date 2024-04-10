using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            for(int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    for (int j = i + 1; j < input[i + 1]; j++)
                    {
                        int strength = input[i + 1];
                        if (input[1] == '>')
                        {
                            strength += input[j + 1];
                        }
                        else
                        {
                            input.Remove(j, strength);
                        }
                    }
                }
            }
            Console.WriteLine(input);
        }
    }
}
