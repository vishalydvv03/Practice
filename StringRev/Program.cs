using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRev
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int n = s.Length;
            char[] ch = s.ToCharArray();
            for(int i=0; i<n/2; i++)
            {
                char temp = ch[i];
                ch[i] = ch[n - i - 1];
                ch[n-i-1] = temp;
            }

            String rev = new String(ch);
            Console.WriteLine($"Reverse String is {rev}");

            Console.ReadKey();
        }
        
    }
}
