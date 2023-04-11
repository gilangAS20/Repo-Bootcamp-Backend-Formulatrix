// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//string userInputName = Console.ReadLine();
//string userInputAge = Console.ReadLine();
using System;
namespace ClassObjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calObject = new Calculator();

            int inputNumberOne = Convert.ToInt32(Console.ReadLine());
            int inputNumberTwo = Convert.ToInt32(Console.ReadLine());

            int resultSum = calObject.Sum(inputNumberOne, inputNumberTwo);
            int resultDecrease = calObject.Decrease(1, 2);
            int resultMultiply = calObject.Multiply(1, 2);
            int resultDivide = calObject.Divide(1, 2);

            Console.WriteLine("total sum: " + resultSum);
            Console.WriteLine("total decrease: " + resultDecrease);
            Console.WriteLine("total multiply: " + resultMultiply);
            Console.WriteLine("total divide: " + resultDivide);
            //Console.ReadKey();
        }
    }

    public class Calculator
    {
        public int Sum(int numberOne, int numberTwo)
        {
            //totalSum = numberOne + numberTwo;
            int sum =  numberOne + numberTwo;
            return sum;
        }

        public int Decrease(int numberOne, int numberTwo)
        {
            int decrease =  numberOne - numberTwo;
            return decrease;
        }

        public int Multiply(int nomorSatu, int nomorDua)
        {
            int multiply = nomorSatu * nomorDua;
            return multiply;
        }

        public int Divide(int angkaSatu, int angkaDua)
        {
            int divide = angkaSatu / angkaDua;
            return divide;
        }
    }
}