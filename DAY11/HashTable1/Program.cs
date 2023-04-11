// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace TryHashTable1
{
    class Program
    {
        static void Main()
        {
            Hashtable tryHashTable1 = new Hashtable();
            // dibawah ini kalo maksa diurutkan gak bisa, karena beda tipe data
            // tryHashTable1.Add("gilang", 1);
            // tryHashTable1.Add(2, "agung");
            // tryHashTable1.Add('C', 3);

            tryHashTable1.Add("gilang", 1);
            tryHashTable1.Add("agung", 2);
            tryHashTable1.Add("caca", 3);

            try
            {
                tryHashTable1.Add("caca", 3);
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
            

            foreach(var result in tryHashTable1) // kenapa hasil yang muncul tidak urut/ tidak sama saat run lagi?
            {
                System.Console.WriteLine(result);
            }

            var sortedDictionary = tryHashTable1.Cast<DictionaryEntry>().OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach(var result in sortedDictionary)
            {
                System.Console.WriteLine($"Key: {result.Key}, Value: {result.Value}");
            }

            System.Console.WriteLine("Apakah tryHashTable1 contains '1' ? " + tryHashTable1.Contains(1));
            System.Console.WriteLine("Apakah tryHashTable1 contains 'gilang' ? " + tryHashTable1.Contains("gilang"));
            System.Console.WriteLine(("Apakah tryHashTable1 containsKey 'gilang' ? " + tryHashTable1.ContainsKey("gilang")));
            System.Console.WriteLine(("Apakah tryHashTable1 containsValue 'gilang' ? " + tryHashTable1.ContainsValue("gilang")));
            System.Console.WriteLine(("Apakah tryHashTable1 containsValue '3' ? " + tryHashTable1.ContainsValue(3)));

            
        }
    }
}