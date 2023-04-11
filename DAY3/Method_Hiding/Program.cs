// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
namespace AbstractClassesAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            Shape shape = new Circle();
            //Circle circle2 = new Shape(); // kode di samping akan menghasilkan error

            //override
            shape.GetArea2(); //GetArea2 but in Circle
            circle.GetArea2(); //GetArea2 but in Circle
            //method hiding
            shape.GetArea3(); //"GetArea3" karena GetArea3() karena pada class circle diberi new
            circle.GetArea3(); //"GetArea3 but in Circle", dia ambil punyanya sendiri
            circle.GetArea4(); //"GetArea4 but in circle", dia ambil punyanya sendiri
            shape.GetArea4(); //"GetArea4", dia ambil punyanya sendiri meskipun pakai new Circle()

            Console.ReadKey();
        }
    }
    public abstract class Shape
    {
        public abstract double GetArea();
        public virtual void GetArea2() {
            Console.WriteLine("GetArea2");
        }
        public virtual void GetArea3 () {
            Console.WriteLine("GetArea3");
        }
        public void GetArea4() {
            Console.WriteLine("GetArea4");
        }
    }


    public interface IShape  {
        double GetArea(int a);
    }


    class Circle : Shape, IShape {
        public override double GetArea()
        {
            return 22/7;
        }
        public override void GetArea2()
        {
            Console.WriteLine("GetArea2 but in Circle");
        }
        public new void GetArea3()
        {
            Console.WriteLine("GetArea3 but in Circle");
        }
        public double GetArea(int a)
        {
            return 22/7;
        }

        public new void GetArea4() {
            Console.WriteLine("GetArea4 but in circle");
        }
    }
}
