// See https://aka.ms/new-console-template for more information
using System;
using System.Threading;
using System.Diagnostics;


class Program
{
    public static void Main()
    {
        Console.WriteLine("Program starting");
        var stopwatch = new Stopwatch();
        stopwatch.Start();

        System.Console.WriteLine("dibawah ini adalah hasil sync");
        DoTaskOne();
        DoTaskTwo();

        var thread1 = new Thread(DoTaskOne);
        var thread2 = new Thread(DoTaskTwo);
        System.Console.WriteLine("dibawah ini adalah hasil thread(async)");
        thread1.Start();
        thread2.Start();
        
        // di bawah ini untuk menjalankan method secara synchronus
        // dikerjakan urut sampai 1 method tsb selesai, baru method selanjutnya

    }

    public static void DoTaskOne()
    {
        Console.WriteLine("Task 1 starting");
        Thread.Sleep(1000);
        Console.WriteLine("Task 1 finished");
    }

    public static void DoTaskTwo()
    {
        Console.WriteLine("Task 2 starting");
        Thread.Sleep(1000);
        Console.WriteLine("Task 2 finished");
    }
}

