// See https://aka.ms/new-console-template for more information
// auto reset event
using System;
using System.Threading;
using System.Threading.Tasks;

static class Program
{
	static async Task Main(string[] args)
	{
		Console.WriteLine("Main Method Started");
		AutoResetEvent autoResetEvent = new AutoResetEvent(false);
		
		var task1 = Task.Run(async () =>
		{
			Console.WriteLine("Task 1 started");
			Console.WriteLine("Task 1 waiting for signal");
			await Task.Run(() => 
            {
                while(!autoResetEvent.WaitOne())
                {
                    System.Console.WriteLine("Task 1 still waiting for signal");
                }
            });
			Console.WriteLine("Task 1 received signal");
            System.Console.WriteLine("Task 1 complete");
			// MyMethod
		});

		var task2 = Task.Run(async () =>
		{
			Console.WriteLine("Task 2 started");
			// MyMethod
			Console.WriteLine("Task 2 waiting for signal");
            await Task.Run(() => 
            {
                while(!autoResetEvent.WaitOne())
                {
                    System.Console.WriteLine("Task 2 still waiting for signal");
                }
            });
			Console.WriteLine("Task 2 received signal");
            System.Console.WriteLine("Task 2 complete");
		});

        var task3 = Task.Run(async () =>
		{
			Console.WriteLine("Task 3 started");
			Console.WriteLine("Task 3 completed work");
			autoResetEvent.Set();
			Console.WriteLine("Task 3 signaled task1 or task 2");
            System.Console.WriteLine("Task 3 complete work");
			// MyMethod
		});

        var task4 = Task.Run(async () =>
		{
			Console.WriteLine("Task 4 started");
			Console.WriteLine("Task 4 completed work");
			autoResetEvent.Set();
			Console.WriteLine("Task 4 signaled task1 or task2");
            System.Console.WriteLine("Task 4 complete work");
			// MyMethod
		});

		await Task.WhenAll(task1, task2, task3, task4);

		Console.WriteLine("Main Method Completed");
		//Console.ReadKey();
	}
}
