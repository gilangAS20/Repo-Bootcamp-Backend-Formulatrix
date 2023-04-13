// See https://aka.ms/new-console-template for more information
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Task task = Task.Run(() => System.Console.WriteLine("Task.Run sedang berjalan"));
        Task kontinyu = task.ContinueWith(t => System.Console.WriteLine("Task continue sedang berjalan"));
        kontinyu.Wait();
    }
}
