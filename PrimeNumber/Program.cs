using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {
        public static bool isPrime(int n)
        {
            if (n <= 1)
            {
                return false;
            }

            if (n == 2)
            {
                return true;
            }
            
            for(int i=2; i*i<n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            if (isPrime(num))
            {
                Console.WriteLine($"{num} is a prime number");
            }
            else
            {
                Console.WriteLine($"{num} is not a prime number");
            }
            Console.ReadKey();
        }
    }
}
