// See https://aka.ms/new-console-template for more information
// MEMBUAT THREAD BARU, 1 tok

using System;
using System.Threading;

static class Program
{
    static void Main()
    {
        Thread newThread1 = new Thread(PrintNumbers);
        newThread1.Start();
    }

    static void PrintNumbers()
    {
        Console.WriteLine("Starting...");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Thread: "+i);
            Thread.Sleep(1000);
        }
        Console.WriteLine("Finished...");
    }
}
