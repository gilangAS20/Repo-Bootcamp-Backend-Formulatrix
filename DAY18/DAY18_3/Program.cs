// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/*
using System;
using System.Threading;

class Program
{
	static void Main()
	{
		// Create a new thread
		Thread thread1 = new Thread(DoWork);
		Thread thread2 = new Thread(DoWork);

		// Set some properties
		thread1.Name = "Worker Thread";
		thread2.Name = "Second Worker Thread";

		// Start the thread
		thread1.Start();
		thread2.Start();

		Console.WriteLine("Main thread exiting.");
	}

	static void DoWork()
	{
		Console.WriteLine($"Thread {Thread.CurrentThread.Name} started.");
		Thread.Sleep(2000);
		Console.WriteLine($"Thread {Thread.CurrentThread.Name} finished.");
	}
}
*/



using System;
using System.Threading;

class Program
{
	static void Main()
	{
		// Create a new thread
		Thread thread = new Thread(DoWork);
		Thread secondThread = new Thread(DoWork);

		// Set some properties
		thread.Name = "Worker Thread";
		secondThread.Name = "Second Worker Thread";

		// Start the thread
		thread.Start();
		secondThread.Start();

		Console.WriteLine("Main thread exiting.");
	}

	static void DoWork()
	{
		Console.WriteLine($"Thread {Thread.CurrentThread.Name} started.");
		Thread.Sleep(2000);
		Console.WriteLine($"Thread {Thread.CurrentThread.Name} finished.");
	}
}
