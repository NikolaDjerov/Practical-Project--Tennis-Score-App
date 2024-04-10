using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            StringBuilder result = new StringBuilder();
            foreach(string username in usernames)
            {
                if(username.Length >= 3 && username.Length <= 16)
                {
                    if (username.Length >= 3 && username.Length <= 16
                        && !username.Contains('-')
                        && !username.Contains('-')
                        && CheckForNumsLetters(username))
                    {
                        result.Append(username);
                    }
                }
            }
        }
        static bool CheckForNumsLetters(string str)
        {
            foreach(char c in str)
            {
                if (!char.IsLetter(c) && !char.IsDigit(c) && c!= '-' && c!= '_')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
