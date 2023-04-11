using System;

namespace AnimalProgram
{
    class Program
    {
        static void Main()
        {
            Poodle poodle = new Poodle();
            poodle.Bark();
            poodle.Eat();
            poodle.Jump();

            //Poodle dogzz = new Dog();
            //dogzz.Eat();
            Poodle dogzzz = new Poodle();
            dogzzz.Eat();
        }
    }

    public interface IAnimal
    {
        void Eat();
    }

    public interface IDog : IAnimal
    {
        void Eat(int food);
        void Bark();
        void Jump();
    }

    public abstract class Dog : IDog
    {
        public void Eat(int food)
        {
            Console.WriteLine("Dog Eat");
        }
        public void Bark()
        {
            Console.WriteLine("Bark");
        }
        public virtual void Eat()
        {
            Console.WriteLine("Dog Eat");
        }
        public abstract void Jump();
    }

    public class Poodle : Dog {
        public override void Jump() {
            Console.WriteLine("Poodle Jump");
        }
        public new void Eat() {
            Console.WriteLine("Poodleeeeee Eat");
        }
    }
}
