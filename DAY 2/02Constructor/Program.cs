// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
namespace ConstructorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat memong = new Cat();
            //memong.name = "Memong";
            memong.SetName("Memong");
            Console.WriteLine(memong.GetName());
        }
    }

    public class Cat
    {
        private string name;

        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }
    }
}