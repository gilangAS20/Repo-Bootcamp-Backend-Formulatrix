using System.Diagnostics;

class Program 
{
    static void Main() 
    {
        int x = 5, y = 7;

        // Use Debug to print a message to the Output window and pause the debugger
        Debug.WriteLine("Starting program...");
        Debug.WriteLine("x = " + x);
        Debug.WriteLine("y = " + y);
        Debug.WriteLine("");

        // Use Trace to print a message to the Output window without pausing the debugger
        Trace.WriteLine("Calculating x + y...");
        int sum = x + y;
        Trace.WriteLine("x + y = " + sum);
        Trace.WriteLine("");

        // Use Debug.Assert to check if a condition is true and pause the debugger if it's false
        Debug.Assert(sum == 12, "The sum of x and y should be 11");

        Debug.WriteLine("Press any key to exit...");
    }
}
