// See https://aka.ms/new-console-template for more information
using System;
using System.Text;

namespace TryString
{
    class Program
    {
        static void Main()
        {
            string a = "yuhu";

            for(int i=0; i<=100000; i++)
            {
                a += "A";
                a += "B";
                //System.Console.WriteLine(a);

            }
            System.Console.WriteLine("Program finished");
            //GC.Collect();
            Console.ReadKey();
        }
    }
}
