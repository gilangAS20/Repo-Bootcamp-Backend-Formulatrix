using System;
using System.Diagnostics.Contracts;

namespace ContractAssertExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two positive integers to multiply:");

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int result = Multiply(num1, num2);

            Console.WriteLine($"The result is {result}");
        }

        static int Multiply(int num1, int num2)
        {
            Contract.Assert(num1 > 0, "num1 must be a positive value");
            Contract.Assert(num2 > 0, "num2 must be a positive value");

            int result = num1 * num2;

            return result;
        }
    }
}
