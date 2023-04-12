#define WINDOWS
#define PROJECT
using System;

public class Program
{
    public static void Main()
    {
#if DEBUG
        Console.WriteLine("Debug mode is on.");
#else
			Console.WriteLine("Debug mode is off.");
#endif

#if PROJECT
        Console.WriteLine("Project mode is on.");
#else
			Console.WriteLine("Project mode is off.");
#endif

#if DEBUG
        if (true)
#else
    if (false)
#endif
        {
            Console.WriteLine("Debug mode is on.");
        }
        else
        {
            Console.WriteLine("Debug mode is off.");
        }

    }
}
