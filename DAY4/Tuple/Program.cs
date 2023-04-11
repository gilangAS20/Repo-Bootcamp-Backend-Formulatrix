// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

namespace TryTuple
{
    static class Program
    {
        static void Main()
        {
            int a = 5;
            string b = "Hello";
            Console.WriteLine($"Before method call, a={a}, b={b}");

            (int c, string d) yuhu = MyMethod(a, b);
            Console.WriteLine($"After method (MyMethod) call, a={yuhu.c}, b={yuhu.d}");
        }

        static (int, string) MyMethod(int x, string y)
        {
            x++;
            y += " World";

            return (x, y);
        }
    }
}