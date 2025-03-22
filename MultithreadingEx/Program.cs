using System;
using System.Threading;

class MultiThreadExample
{
    static void PrintNumbers()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Thread 1: {i}");
            Thread.Sleep(500);
        }
    }

    static void PrintAlphabets()
    {
        for (char c = 'A'; c <= 'E'; c++)
        {
            Console.WriteLine($"Thread 2: {c}");
            Thread.Sleep(500);
        }
    }

    static void Main()
    {
        Thread thread1 = new Thread(PrintNumbers);
        Thread thread2 = new Thread(PrintAlphabets);

        thread1.Start();
        thread2.Start();

        thread1.Join();
        thread2.Join();

        Console.WriteLine("Main thread completed");
    }
}
