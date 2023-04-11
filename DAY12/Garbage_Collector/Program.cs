// See https://aka.ms/new-console-template for more information
namespace Garbage_Collector
{
    class DestructorDemo
    {
        public DestructorDemo()
        {
            System.Console.WriteLine("Constructor called");
        }
        ~DestructorDemo()
        {   
            string type = GetType().Name;
            System.Console.WriteLine($"Object {type} is being destroyed");
        }
    }

    class Program
    {
        static void Main()
        {
            System.Console.WriteLine("--TESTING GC--");
            DestructorDemo obj1 = new DestructorDemo();
            DestructorDemo obj2 = new DestructorDemo();

            obj1 = null;
            //GC.Collect();
        }
    }
}
