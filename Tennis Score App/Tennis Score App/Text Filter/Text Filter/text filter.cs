using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] censor = Console.ReadLine().Split(", ");
            StringBuilder text= new StringBuilder(Console.ReadLine());
            foreach(string ban in censor)
            {
                 while(text.ToString().Contains(ban))
                 {
                    text.Replace(ban, new string('*', ban.Length));                     
                 }
            }
            Console.WriteLine(text.ToString());
        }
    }
}
