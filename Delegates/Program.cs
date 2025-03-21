using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    delegate void PrintMsgDelegate(string msg);
    class Program
    {
        public void PrintMsg(string name)
        {
            Console.WriteLine("Hello, "+ name);
        }
        static void Main(string[] args)
        {
            
            Program p1 = new Program();

            //Normal Method

            //PrintMsgDelegate print = new PrintMsgDelegate(p1.PrintMsg);
            //print.Invoke("Vishal");

            //Anonymous Method

            //PrintMsgDelegate print = delegate (string name) {
            //    Console.WriteLine("Enter your name : ");
            //    name = Console.ReadLine();
            //    Console.WriteLine($"Hello {name}, Have a good day !!");
            //};

            //print("Vishal");

            //Lambda Expressions

            PrintMsgDelegate print = (name) => {
                Console.WriteLine("Enter your name : ");
                name = Console.ReadLine();
                Console.WriteLine($"Hello {name}, Have a good day !!");
            };

            print("Vishal");


        }
    }
}
