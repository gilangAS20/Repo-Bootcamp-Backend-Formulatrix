// See https://aka.ms/new-console-template for more information
using System;
using System.Threading;
using System.Diagnostics;
// mencoba pakai join
public class Program
{
    static void Main()
    {
        System.Console.WriteLine("TEST THREAD WITH JOIN");

        var thread1 = new Thread(DoingSomething);

        thread1.Start();
        // Join() akan men-stop main thread sampai thread yang di join selesai
        thread1.Join();

        System.Console.WriteLine("program selesai");
    }

    public static void DoingSomething()
    {
        System.Console.WriteLine("Doing something");
        Thread.Sleep(1000);
        System.Console.WriteLine("done");
    }
}