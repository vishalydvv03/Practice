using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int rev = 0;
            while (num != 0)
            {
                int lastDigit = num % 10;
                rev = rev * 10 + lastDigit;
                num = num / 10;
            }
            Console.WriteLine($"Reverse Number is {rev}");
            Console.ReadKey();
        }
        
    }
}
