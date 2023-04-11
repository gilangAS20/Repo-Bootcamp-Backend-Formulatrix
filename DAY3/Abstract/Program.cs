// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

public class Program
{
    public static void Main()
    {
        Persegi square = new Persegi(5);
        Console.WriteLine($"Luas persegi: {square.CalculateArea()}");
    }

    public abstract class Shape
    {
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
    }

    public class Persegi : Shape
    {
        public double sisi;

        public Persegi(double s)
        {
            sisi = s;
        }

        public override double CalculateArea()
        {
            return sisi * sisi;
        }

        public override double CalculatePerimeter()
        {
            return 4 * sisi;
        }
    }
}