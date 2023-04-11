// See https://aka.ms/new-console-template for more information
using System;
using System.Text;
using System.Collections;

namespace TryStaticClass
{
    class Program
    {
        static void Main()
        {
            NewInstance new1 = new NewInstance();
            System.Console.WriteLine(NewInstance.counter);
            StringBuilder sb = new StringBuilder();

            for(int i=0; i<= 10000000; i++)
            {
                new1.DisplayCounter();
                sb.Append("A");
            }
            //System.Console.WriteLine(sb);
            System.Console.WriteLine("program selesai");
            Console.ReadKey();
        }
    }

    class NewInstance
    {
        public static int counter = 0;
        public NewInstance()
        {
            counter++;
        }

        public void DisplayCounter()
        {
            //System.Console.WriteLine(counter);
            counter++;
        }
    }
}
