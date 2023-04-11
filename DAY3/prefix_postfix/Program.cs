// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

public class Program
{
    public static void Main()
    {
        int x = 2;
        int y = x++;
        //nilai y akan tetap 2(seperti x awal), karena nilai x dimasukkan ke y dulu baru ditambah 1

        int a = 2;
        int b = ++a;
        // nilai b akan menjadi 3, karena nilai a ditambah 1 dulu baru dimasukkan ke b


        Console.WriteLine($"Nilai awal x = {x}, nilai y dengan x++ = {y}");
        Console.WriteLine($"Nilai awal a = {a}, nilai b dengan ++a = {b}");
    }
}


