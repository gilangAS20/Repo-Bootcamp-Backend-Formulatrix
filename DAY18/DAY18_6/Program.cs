// See https://aka.ms/new-console-template for more information
using System;
using System.Threading;

class Program
{
    static void Main()
    {
        // membuat thread baru
        Thread thread1 = new Thread(PrintAngka);

        // start thread
        thread1.Start();

        System.Console.WriteLine("Apakah thread masih ada? : " + thread1.IsAlive);

        thread1.Priority = ThreadPriority.AboveNormal;

        thread1.IsBackground = true;

        // join thread
        thread1.Join();

        System.Console.WriteLine("Main thread selesai berjalan");
        System.Console.WriteLine("Apakah thread masih ada? : " + thread1.IsAlive);
    }

    static void PrintAngka()
    {
        for(int i =0; i<10; i++)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
    }
}
