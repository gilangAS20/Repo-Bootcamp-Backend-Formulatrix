using System.Diagnostics;
using System.IO;

namespace ExampleApplication
{
	class Program
	{
		static void Main(string[] args)
		{
			// Clear any existing trace listeners
			Trace.Listeners.Clear();
			
			// Create a new TextWriterTraceListener to write output to a file
			TextWriterTraceListener traceListener = new TextWriterTraceListener("myTraceOutput.txt");
			
			// Add the trace listener to the Trace object
			Trace.Listeners.Add(traceListener);
			Trace.Assert(true, "This is a trace false.");
			
			// Write a trace statement to output something to the file
			Trace.WriteLine("This is a trace statement.");
			
			// Flush and close the trace listener to ensure all output is written to the file
			traceListener.Flush();
			traceListener.Close();
		}
	}
}
