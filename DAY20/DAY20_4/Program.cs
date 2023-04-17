// See https://aka.ms/new-console-template for more information
using System;
using System.IO;

namespace TryUsing
{
    class Program
    {
        static void Main()
        {
            string pathFile = @"D:\bootcamp_formulatrix\Repo-Bootcamp-Backend-Formulatrix\DAY20\DAY20_4\tryUsing.txt";

            using(FileStream fileStream = new FileStream(pathFile, FileMode.OpenOrCreate))
            {
                using(StreamReader streamReader = new StreamReader(fileStream))
                {
                    string text = streamReader.ReadToEnd();
                    System.Console.WriteLine("try to read file: ");
                    if(text == "")
                    {
                        System.Console.WriteLine("File kosong");
                    }
                    else
                    {
                        System.Console.WriteLine(text);
                    }
                }
            }
        }
    }
}
