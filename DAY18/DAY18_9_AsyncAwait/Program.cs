// See https://aka.ms/new-console-template for more information
using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        System.Console.WriteLine("program dimulai");
        await DoWorkAsync();
        System.Console.WriteLine("program selesai");
    }

    static async Task DoWorkAsync()
    {
        System.Console.WriteLine("DoWorkAsync dimulai");
        await Task.Delay(5000);
        System.Console.WriteLine("DoWorkAsync selesai");
    }
}
