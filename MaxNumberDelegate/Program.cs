using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumberDelegate
{
    public delegate int MaxDelegate(int[] arr, int n);
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 10, 30, 50, 70 };
            int n = arr.Length;
            MaxDelegate maxDel = (arr1, n1) => {
                int max = arr1[0];
                for (int i = 0; i < n1; i++)
                {
                    if (arr1[i] > max)
                    {
                        max = arr1[i];
                    }
                }
                return max;
            };
             
            Console.WriteLine(maxDel.Invoke(arr, n));

            Console.ReadKey();
        }
    }
}




