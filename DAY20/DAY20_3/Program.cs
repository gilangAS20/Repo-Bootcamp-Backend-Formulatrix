using System;
using System.IO;

namespace FileCreation
{
    class Program
    {
        static void Main() // tidak pakai using, jadi saat file sudah dibuka dan selesai, harus ditutup dari memori
        {
            string path = @"D:\bootcamp_formulatrix\Repo-Bootcamp-Backend-Formulatrix\DAY20\DAY20_3\testCreateText.txt";
            FileStream fstream = new FileStream(path, FileMode.OpenOrCreate);
            StreamReader sreader = new StreamReader(fstream);
            System.Console.WriteLine("File berhasil dibuat");

            string text = sreader.ReadToEnd();
            System.Console.WriteLine("try to read file: ");
            if(text == "")
            {
                System.Console.WriteLine("File kosong");
            }
            else
            {
                System.Console.WriteLine(text);
            }

            sreader.Close();
            fstream.Close();  
        }
    }
}