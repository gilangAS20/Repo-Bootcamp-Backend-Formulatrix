using System;

/*
class Program 
{
    static void Main(string[] args) 
    {
        try 
        {
            // Code that may throw an exception
            int a = 10, b = 0;
            int c = a / b;
        } 
        catch (Exception ex) 
        {
            // Code to handle the exception
            Console.WriteLine("An error occurred: {0}", ex.Message);
        } 
        finally 
        {
            // Code that will always be executed, regardless of whether an exception was thrown or not
            Console.WriteLine("The program has finished executing.");
        }
    }
}
*/

namespace TryandCatch;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            int[] numbers = { 1, 2, 3 };
            Console.WriteLine(numbers[5]); // IndexOutOfRangeException

            int q = 0;
            int x = 10 / q; // DivideByZeroException

            string s = null;
            Console.WriteLine(s.Length); // NullReferenceException

            int y = int.Parse("hello"); // FormatException
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine("Oops, you went out of bounds!");
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("Oops, you tried to divide by zero!");
        }
        catch (NullReferenceException e)
        {
            Console.WriteLine("Oops, you tried to use a null reference!");
        }
        catch (FormatException e)
        {
            Console.WriteLine("Oops, there was a problem parsing the input!");
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred: " + e.Message);
        }

        try
        {
            Console.WriteLine("Please enter the path to the file:");
            string filePath = Console.ReadLine();

            // Attempt to read the file and display its contents
            string fileContents = File.ReadAllText(filePath);
            Console.WriteLine("File contents:");
            Console.WriteLine(fileContents);
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine("File not found: " + e.Message);
        }
        catch (IOException e)
        {
            Console.WriteLine("An I/O error occurred: " + e.Message);
        }
        catch (UnauthorizedAccessException e)
        {
            Console.WriteLine("You do not have permission to access this file: " + e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred: " + e.Message);
        }

    }
}

