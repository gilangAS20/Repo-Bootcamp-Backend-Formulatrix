// See https://aka.ms/new-console-template for more information
using System;
using System.IO;

public class MainProgram
{
    static void Main()
    {
        //buat instance dari class TryLogger
        TryLogger logger1 = new();
        logger1.Log("Program started");
        logger1.Log("Program ended");

        // menampilkan isi dari file MyFirstLog.txt
        using(StreamReader reader = new("MyFirstLog.txt"))
        {
            string line;
            while((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}

public class TryLogger
{
    private string logFileTxt = "MyFirstLog.txt";
    public void Log(string msg)
    {
        using(StreamWriter writer = new(logFileTxt, true))
        {
            writer.WriteLine($"{DateTime.Now} - {msg}");
        }
    }
}