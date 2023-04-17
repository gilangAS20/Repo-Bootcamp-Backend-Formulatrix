// See https://aka.ms/new-console-template for more information
using System.IO;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        string path = @"../DAY20_1/test20_2.txt";
        using (StreamReader sReader = new StreamReader(path))
        {
            char[] buffer = new char[2048];
            int bytesRead;
            while((bytesRead = await sReader.ReadAsync(buffer, 0, buffer.Length)) > 0)
            {
                string text = new string(buffer, 0, bytesRead);
                Console.Write(text);
            }
            System.Console.WriteLine("\n Done reading file.");
        };
    }
}