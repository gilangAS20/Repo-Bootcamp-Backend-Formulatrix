// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

namespace LambdaExpression
{
    class Program
    {
        static void Main()
        {   string name = "Rectangle";
            int length = 10;
            Console.WriteLine("Length: " + length);

            //Lambda Expression
            Rectangle rectangle1 = new Rectangle(() => length * length);
            
        }

        public class Rectangle
        {
            //public string Name { get; set; }
            int length;

            //static Rectangle(int length)// {get => length*length; set => length = value;}
            public Rectangle(Func<int> getArea)
            {
                //Name = name;
                length = getArea();
                Console.WriteLine("Areaa: " + length);
            }
        }
    }
}