// See https://aka.ms/new-console-template for more information
using System;

namespace GenericCoba
{
    public class Program
    {
        static void Main()
        {
            MyGenericClass<int> myGenericClassInt = new MyGenericClass<int>(10);
            Console.WriteLine(myGenericClassInt.GetVariable());

            MyGenericClass<double> myGenericClassString = new MyGenericClass<double>(12.7);
            Console.WriteLine(myGenericClassString.GetVariable());

            MyGenericClass<string> myGenericClassDouble = new MyGenericClass<string>("Hello World");
            Console.WriteLine(myGenericClassDouble.GetVariable());
        }
    }

    public class MyGenericClass<T>
    {
        //public T myVariable;
        private T myVariable2;

        public MyGenericClass(T value)
        {
            myVariable2 = value;
        }

        
        public T GetVariable()
        {
            return myVariable2;
        }
        
    }
}
