using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallBackDelegate
{
    public delegate void CallDelegate(int i);

    class Program
    {
        static void Main(string[] args)
        {
            MyClass.LongRun(new CallDelegate(Print));
            Console.ReadKey();

        }

        public static void Print(int i)
        {
            if(i%2==0)
                Console.WriteLine(i);
            
        }
    }

    class MyClass : Exception
    {
        public static void LongRun(CallDelegate del)
        {
            for(int i=0; i<100; i++)
            {
                del.Invoke(i);
            }
        }

    }
}
