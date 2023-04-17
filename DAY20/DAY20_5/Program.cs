// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Diagnostics;
class Program
{
    static void Main()
    {
        using(StreamReader sreader = new StreamReader("TestAsync.txt"))
        {
            Stopwatch sw1 = Stopwatch.StartNew();
            sw1.Start();
            System.Console.WriteLine("non async: ");
            string result = sreader.ReadToEnd();
            //System.Console.WriteLine(result);
            sw1.Stop();
            System.Console.WriteLine("Time elapsed: {0}", sw1.ElapsedMilliseconds);
        }

        System.Console.WriteLine("\n");

        using(StreamReader sr = new StreamReader("TestAsync.txt"))
        {
            Stopwatch sw2 = Stopwatch.StartNew();
            sw2.Start();
            System.Console.WriteLine("async: ");
            string result = sr.ReadToEndAsync().Result;
            //System.Console.WriteLine(result);
            sw2.Stop();
            System.Console.WriteLine("Time elapsed: {0}", sw2.ElapsedMilliseconds);
        }

    }
}
