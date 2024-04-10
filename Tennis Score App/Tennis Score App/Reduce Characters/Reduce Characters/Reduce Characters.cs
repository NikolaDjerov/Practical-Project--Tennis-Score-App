using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reduce_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            string character = Console.ReadLine();
            string allVowels = "AEIOUaeiou";
            string endCharacter = "";
            foreach (char vowel in character)
            {
                 if (allVowels.IndexOf(vowel) != -1)
                 {
                 }
                 else
                 {
                     endCharacter += vowel;
                 }
            }
            Console.WriteLine(endCharacter);
        }
    }
}
