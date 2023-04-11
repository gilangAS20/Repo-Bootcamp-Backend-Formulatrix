// See https://aka.ms/new-console-template for more information
using System;
using System.Text;
using System.Collections;

namespace StringBuilderTry
{
    class Program
    {
        static void Main()
        {
            //int i = 0;
            StringBuilder sb = new StringBuilder();

            for(int i=0; i <=100; i++)
            {
                sb.Append("A");
                sb.Append("B");
                sb.Replace("AB", "zzz");
                //System.Console.WriteLine(sb);
            }
            System.Console.WriteLine("Program finished");
            Console.ReadKey();
        }
    }
}
