﻿// See https://aka.ms/new-console-template for more information
using System;
using System.IO;

class Test
{
    static void Main()
    {
        string path = @"D:\bootcamp_formulatrix\Repo-Bootcamp-Backend-Formulatrix\DAY20\DAY20_1\testFileStream.txt";
        if(!File.Exists(path))
        {
            //create file and write on it
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine("gilang mencoba streamwriter");
                sw.WriteLine("adadehhhh");
                sw.WriteLine("yuhuww");
            }
        }

        // read text in file
        using(StreamReader sr = File.OpenText(path))
        {
            string text;
            while((text = sr.ReadLine()) != null)
            {
                System.Console.WriteLine(text);
            }
        }
    }
}
