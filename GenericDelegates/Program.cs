using System;

namespace GenericDelegate
{
    public class Program
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public static void Main()
        {
            Func<int, int, int> addDelegate = Add;
            int sum = addDelegate(3, 5);
            Console.WriteLine("Sum: " + sum);

            Action<string> printDelegate = PrintMessage;
            printDelegate("This is a message from Action delegate.");

            Predicate<int> isEvenDelegate = IsEven;
            bool result = isEvenDelegate(4);
            Console.WriteLine("Is 4 even? " + result);
            Console.ReadKey();
        }
    }
}

