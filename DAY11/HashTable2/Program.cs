// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace TryHashTable2
{
    class Program
    {
        static void Main()
        {
            Hashtable tryHashTable2 = new Hashtable();

            tryHashTable2.Add("Toyota", "Corola, Avanza, Alphard");
            System.Console.WriteLine(tryHashTable2["Toyota"]);

            tryHashTable2["Toyota"] += ", Xenia";
            System.Console.WriteLine(tryHashTable2["Toyota"]);


            Hashtable tryHashTable3 = new Hashtable();
            tryHashTable3.Add("Name", "Gilang");
            tryHashTable3.Add("ID", "Yuki");

            System.Console.WriteLine("Print isi dari tryHashTable3");
            foreach(var result in tryHashTable3)
            {
                System.Console.WriteLine(result);
            }

            System.Console.WriteLine("\n try to remove Yuki ini tryHashTable3");
            tryHashTable3.Remove("ID");
            System.Console.WriteLine("Result: ");
            System.Console.WriteLine("Print isi dari tryHashTable3");
            foreach(var result in tryHashTable3)
            {
                System.Console.WriteLine(result);
            }

            //System.Console.WriteLine(tryHashTable3["Name"]);


            
            
            //memisahkan value dengan koma
            string[] splitValue = tryHashTable2["Toyota"].ToString().Split(", ");
            System.Console.WriteLine("\nSplit value dari key 'Toyota': ");
            foreach(var result in splitValue)
            {
                System.Console.WriteLine(result);
            }

            System.Console.WriteLine("\nNilai value dari string index ke 0: ");
            System.Console.WriteLine(splitValue[0]);

            System.Console.WriteLine("\nNilai value dari string index ke 1: ");
            System.Console.WriteLine(splitValue[1]);

            System.Console.WriteLine("\nNilai value dari string index ke 2: ");
            System.Console.WriteLine(splitValue[2]);

            System.Console.WriteLine("\nNilai value dari string index ke 3: ");
            System.Console.WriteLine(splitValue[3]);

        }
    }
}