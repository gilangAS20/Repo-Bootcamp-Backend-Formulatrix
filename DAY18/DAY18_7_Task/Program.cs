using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var task = new Task(() => Console.WriteLine("Hello, Task!"));
        task.Start();
        task.Wait(); // Wait for the task to complete

        // dibawah ini ada yang nampung yaitu task1
        Task task1 = Task.Run(() => Console.WriteLine("Hello, Task.Run!"));
        //task1.Wait();

        // dibawah ini tidak ada yang nampung
        Task.Run(() => Console.WriteLine("Hello, Task.Run! kedua"));
    }
}