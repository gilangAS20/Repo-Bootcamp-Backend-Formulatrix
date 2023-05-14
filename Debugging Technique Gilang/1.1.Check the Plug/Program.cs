// See https://aka.ms/new-console-template for more information

using System;
using System.Text;
class Program
{
    class CheckThePlugOne
    {
        static void Main()
        {   
            Console.WriteLine("Tes Check the Plug");

            StringBuilder inputResult = new();

            Console.WriteLine("Masukkan jumlah inputan: ");
            int jumlahInput = Int32.Parse(Console.ReadLine());

            for(int i = 1; i <= jumlahInput; i++)
            {
                Console.WriteLine($"Masukkan inputan user ke {i}: ");
                string inputUser = Console.ReadLine();
                inputResult.Append(inputUser + "\n");
            }

            Console.WriteLine("Input user adalah: \n" + inputResult);

            Console.WriteLine("Simpan ke dalam file");
            string path = @"E:\bootcamp_formulatrix\Repo-Bootcamp-Backend-Formulatrix\Debugging Technique Gilang\1.1.Check the Plug\WriteInputResult.txt";
            //              E:\bootcamp_formulatrix\Repo-Bootcamp-Backend-Formulatrix\Debugging Technique Gilang\1.1.Check the Plug
            string writeToFile = "Input user adalah: \n" + inputResult.ToString();
            File.WriteAllText(path, writeToFile);

            // print isi dari file
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
        }
    }
}
