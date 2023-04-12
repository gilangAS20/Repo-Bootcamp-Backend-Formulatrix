using System.Diagnostics;

static class Program
{
	static void Main()
	{
		Debug.WriteLine("Debug says, I am watching!");
		Trace.WriteLine("Trace says, I am watching!");
        Console.ReadKey();
    }
}