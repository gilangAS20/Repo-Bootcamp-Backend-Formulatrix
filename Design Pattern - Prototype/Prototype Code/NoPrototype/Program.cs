// See https://aka.ms/new-console-template for more information
using System;

namespace NoPrototype
{
    class ProgramNoPrototype
    {
        static void Main()
        {   
            // make person1
            //================ instance yang mau di-clone ======================
            Console.WriteLine("\nPerson1:");
            Person person1 = new Person("Gilang", 22);
            Console.WriteLine(person1.PrintPerson());
            //==================================================================


            //============ instance-instance yang mau meng-clone ===============
            // make person2, with clone value from person1
            Console.WriteLine("\nPerson2:");
            Person person2 = new Person(person1.Name, person1.Age);
            Console.WriteLine(person2.PrintPerson());

            // make person3, with clone value from person1
            Console.WriteLine("\nPerson3:");
            Person person3 = new Person(person1.Name, 69);
            Console.WriteLine(person3.PrintPerson());

            // make person4, with clone value from person1
            Console.WriteLine("\nPerson4:");
            Person person4 = new Person("Agus", person1.Age);
            Console.WriteLine(person4.PrintPerson());
            //==================================================================
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor
        public Person(string name, int age)
        {   
            Console.WriteLine("Make instance from class Person");
            this.Name = name;
            this.Age = age;
        }

        public string PrintPerson()
        {
            string printPerson = "Name: " + this.Name + 
                                "\nAge: " + this.Age;
            return printPerson;
        }
    }
}
