// See https://aka.ms/new-console-template for more information
/*
try
{
    int a = 10;
    int b = 0;
    int c = a / b;
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
*/

/*
class Program
{
    static void Main()
    {
        try
        {
            int a = 10, b = 0;
            int c = a/b;
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("An error occurred: {0}", ex.Message);
        }
        finally
        {
            Console.WriteLine("blcok 'finally' telah dijalankan");
        }
        Console.WriteLine("try catch selesai");
    }
}
*/

/*
class Program
{
    static void Main()
    {
        try
        {
            int a = 10, b = 0;
            try
            {
                int c = a/b;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("inside trycath: {0}", ex.Message);
            }
            finally
            {
                Console.WriteLine("inside finally");
                int c = a/b;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("outside trycath: {0}", ex.Message);
        }
    }
}
*/

/*
class Program
{
    static void Main()
    {
        try
        {
            int a = 10, b = 0;
            int c = a/b;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("An error occurred: {0}", ex.Message);
        }

        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: {0}", ex.Message);
        }

        finally
        {
            Console.WriteLine("blcok 'finally' telah dijalankan");
        }
        Console.WriteLine("try catch selesai");
    }
}
*/

/*
class Program
{
    static void Main()
    {
        int a = 10;
        int b = 0;
        Calculator operate1 = new();
        try
        {
            int hasilBagi = operate1.Divide(a, b);
            Console.WriteLine(hasilBagi);
            
        }
        catch (Exception err)
        {
            Console.WriteLine(err.Message);
        }
        finally
        {
            Console.WriteLine("block 'finally' telah dijalankan, try catch selesai");
        }
        Console.WriteLine(operate1.Add(a, b));
    }

    class Calculator
    {
        public int Divide(int a, int b)
        {
            return a/b;
        }

        public int Add(int a, int b)
        {
            return a+b;
        }
    }
}
*/


/*
public class MyClass
{
    public int _value;

    public MyClass(int value)
    {
        this._value = value;
    }

    public static MyClass operator + (MyClass a, MyClass b)
    {
        return new MyClass(a._value+b._value);
    }
}

class Program
{
    static void Main()
    {
        MyClass x = new MyClass(10);
        MyClass y = new MyClass(20);
        MyClass z = new MyClass(30);
        MyClass a = new MyClass(40);
        MyClass hasil = x + y + z + a;
        Console.WriteLine(hasil._value);
    }
}
*/


public struct Point
{
    public int X { get; set;}
    public int Y { get; set;}

    public Point(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }

    public static Point operator + (Point a, Point b)
    {
        return new Point(a.X+b.X, a.Y+b.Y);
    }

    public static Point operator - (Point a, Point b)
    {
        return new Point(a.X-b.X, a.Y-b.Y);
    }

    public static Point operator * (Point a, Point b)
    {
        return new Point(a.X*b.X, a.Y*b.Y);
    }

    public static Point operator / (Point a, Point b)
    {
        return new Point(a.X/b.X, a.Y/b.Y);
    }

    public class Program
    {
        static void Main()
        {
            Point p1 = new Point(10, 20);
            Point p2 = new Point(30, 40);
            Point p3 = new Point(50, 60);
            Point p4 = new Point(70, 80);
            Point result =  p1 + p2 + p3 - p4;
            //Point hasil = p1;
            Console.WriteLine("result.X: "+result.X);
            Console.WriteLine("result.Y: "+result.Y);

            Point p5 = new Point(10, 20);
            Point p6 = new Point(30, 40);

            Point result2 = p5 - p6;
            Console.WriteLine(result2.X);
            Console.WriteLine(result2.Y);

            Point p7 = new Point(10, 20);
            Point p8 = new Point(30, 40);

            Point result3 = p7 * p8;
            Console.WriteLine(result3.X);
            Console.WriteLine(result3.Y);

            Point p9 = new Point(10, 20);
            Point p10 = new Point(30, 40);

            Point result4 = p9 / p10;
            Console.WriteLine(result4.X);
            Console.WriteLine(result4.Y);
        }
    }
}


/*
using System;

public class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public static Point operator +(Point p1, Point p2)
    {
        return new Point(p1.X + p2.X, p1.Y + p2.Y);
    }
}
   
public class Program
{
    public static void Main()
    {
        Point p1 = new Point(1, 2);
        Point p2 = new Point(3, 4);
        Point p3 = p1 + p2; // p3 is now a Point with X=4 and Y=6
        Console.WriteLine($"p3.X = {p3.X}, p3.Y = {p3.Y}");
    }
}
*/


