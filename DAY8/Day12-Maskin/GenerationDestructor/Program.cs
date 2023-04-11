using System;
namespace GarbageCollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 1000000; i++)
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
        ~MyClass1()
        {
            //Here, you need to write the code for
            //Unmanaged resource clean up
        }
    }

    public class MyClass2
    {
        ~MyClass2()
        {            
            //Here, you need to write the code for
            //Unmanaged resource clean up
        }
    }

    public class MyClass3
    {
        ~MyClass3()
        {
            //Here, you need to write the code for
            //Unmanaged resource clean up
        }
    }
}