using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            char[] ch = s.ToLower().ToCharArray();
            int n = s.Length;
            bool isPal = true;
            for(int i=0; i<(n/2); i++)
            {
                if (ch[i] != ch[n - i - 1])
                {
                    isPal = false;
                }
            }
            if (isPal)
            {
                Console.WriteLine($"{s} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"{s} is not a palindrome");
            }
            Console.ReadKey();
        }
    }
}
