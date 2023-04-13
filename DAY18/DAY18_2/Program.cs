// See https://aka.ms/new-console-template for more information
// task async await

class Program
{
    static async Task Main()
    {
        Task task1 = Task.Run(async () => {await Task.Delay(1000); System.Console.WriteLine("Hello from task 1");});
        Task task2 = Task.Run(async () => {await Task.Delay(1000); System.Console.WriteLine("Hello from task 2");});

        Task penampung = await Task.WhenAny(task1, task2);
        System.Console.WriteLine("yang selesai duluan adalah: " +(penampung == task1 ? "task 1" : "task 2"));
    }
}
