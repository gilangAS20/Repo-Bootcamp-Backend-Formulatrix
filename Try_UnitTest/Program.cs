// See https://aka.ms/new-console-template for more information
//source: https://www.youtube.com/watch?v=HQmbAdjuB88

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Try Unit Test");
        
        int addResult = Add(1, 2);

        System.Console.WriteLine(addResult);
        System.Console.WriteLine(IsOdd(5));
    }

    public static int Add(int x, int y)
    {
        return x + y;
    }

    public static bool IsOdd(int value)
    {
        return value % 2 == 1;
    }

}
