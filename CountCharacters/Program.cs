using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            char[] ch = s.ToCharArray();
            int upper = 0;
            int lower = 0;


            for(int i=0; i<s.Length; i++)
            {
                if (ch[i]>='A' && ch[i] <= 'Z')
                {
                    upper++;
                }
                if (ch[i] >= 'a' && ch[i] <= 'z')
                {
                    lower++;
                }
            }
            Console.WriteLine($"Upper character count is {upper} and Lower character count is {lower}");
        }
    }
}
