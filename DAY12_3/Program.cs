// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Text;

class TryFileStream
{
    static void Main()
    {
        string path = @"E:\bootcamp_formulatrix\Repo-Bootcamp-Backend-Formulatrix\DAY12_3\Testing.txt";

        // pertama cek dulu apakah sudah ada filenya, kalo ada baiknya dihapus
        if(File.Exists(path))
        {
            File.Delete(path);
        }

        // buat file baru
        using(FileStream fs = File.Create(path))
        {
            AddText(fs, "Gilang mencoba menambahkan text\n");
            AddText(fs, "Gilang mencoba menambahkan text lagi\n");
            AddText(fs, "anjyr slebew\n");

            for(int i=1; i < 100; i++)
            {
                AddText(fs, Convert.ToString(i));
            }
        }
    }
    private static void AddText(FileStream fs, string value)
    {
        byte[] info = new UTF8Encoding(true).GetBytes(value);
        fs.Write(info, 0, info.Length);
    }
}
