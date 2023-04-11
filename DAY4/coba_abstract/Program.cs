// See https://aka.ms/new-console-template for more information
using System;

/*
namespace CobaAbstract
{
    class Program
    {
        static void Main()
        {
            Dog poodle = new Dog();
            poodle.Eat();
            poodle.Bark();
        }
    }

    abstract class Hewan
    {
        public abstract void Eat();

    }

    class Dog : Hewan
    {
        public override void Eat()
        {
            Console.WriteLine("Anjing sedang makan");
        }

        public void Bark()
        {
            Console.WriteLine("Anjing sedang menggonggong");
        }
    }
}
*/

abstract class Shape
{
    public abstract double CalculateArea();
    public abstract double CalculatePerimeter();
}

class Circle : Shape
{
    private double radius;

    public Circle(double r)
    {
        radius = r;
    }

    public override double CalculateArea()
    {
        return Math.PI * radius * radius;
    }

    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * radius;
    }
}

class Rectangle : Shape
{
    private double length;
    private double width;

    public Rectangle(double l, double w)
    {
        length = l;
        width = w;
    }

    public override double CalculateArea()
    {
        return length * width;
    }

    public override double CalculatePerimeter()
    {
        return 2 * (length + width);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Shape circle = new Circle(5);
        Console.WriteLine($"Circle area: {circle.CalculateArea()}");
        Console.WriteLine($"Circle perimeter: {circle.CalculatePerimeter()}");

        Shape rectangle = new Rectangle(3, 4);
        Console.WriteLine($"Rectangle area: {rectangle.CalculateArea()}");
        Console.WriteLine($"Rectangle perimeter: {rectangle.CalculatePerimeter()}");
    }
}

