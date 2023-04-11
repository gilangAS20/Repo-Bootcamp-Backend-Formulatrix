using System;
namespace ConstructorDemo
{
    public class Program
    {
        static void Main()
        {
            Cat memong = new Cat();
            Cat memong2 = new Cat(2, "Memong2", 4);
            Cat memong3 = new Cat(3, "Memong3", 3);

            memong.age = 3;
            memong2.age = 5;
            memong2.SetName("Slebew");
            

            memong.Display();
            memong2.Display();
            memong3.Display();
        }
    }

    public class Cat //overload
    {
        public int age;
        private string name;
        public int legCount;
        
        public Cat()
        {
            age = 0;
            name = "No Name";
            legCount = 4;
        }

        public Cat(int age, string name, int legCount)
        {
            this.age = age;
            this.name = name;
            this.legCount = legCount;
        }
        public void Display()
        {
            Console.WriteLine($"Value of age = {age} and name = {name} and leg = {legCount}");
        }

        public void SetName(string newName)
        {
            name = newName;
        }
    }
}