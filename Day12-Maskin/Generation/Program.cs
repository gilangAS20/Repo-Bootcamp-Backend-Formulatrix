﻿using System;
namespace GarbageCollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100000; i++)
            {
                MyClass1 obj1 = new MyClass1();
                MyClass2 obj2 = new MyClass2();
                MyClass3 obj3 = new MyClass3();
            }

            Console.Read();
        }
    }

    public class MyClass1
    {
    }

    public class MyClass2
    {
    }

    public class MyClass3
    {
    }
} 