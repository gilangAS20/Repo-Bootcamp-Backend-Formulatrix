// See https://aka.ms/new-console-template for more information
using System;

namespace WithPrototype
{
    class ProgramProtoype
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
            Console.WriteLine("\nPerson2: ");
            Person person2 = (Person) person1.Clone(); /* di-casting karena person1.Clone() menghasilkan 
                                                          tipe data Object, sedangkan Person person1
                                                          tipenya Person */
            Console.WriteLine(person2.PrintPerson());

            // make person3, with clone value from person1
            Console.WriteLine("\nPerson3: ");
            Person person3 = (Person) person1.Clone();
            person3.Name = "Tarno";
            Console.WriteLine(person3.PrintPerson());

            // make person3, with clone value from person1
            Console.WriteLine("\nPerson4: ");
            Person person4 = (Person) person1.Clone();
            person4.Age = 90;
            Console.WriteLine(person4.PrintPerson());

            // make person3, with clone value, tetap bisa input manual jika ingin
            Console.WriteLine("\nPerson5: ");
            Person person5 = new Person(person1.Name, person1.Age);
            Console.WriteLine(person5.PrintPerson());

            //==================================================================
        }
    }

    class Person : ICloneable
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

        public object Clone()
        {
            return this.MemberwiseClone(); // method MemberwiseClone() mengembalikan tipe data object
        }
    }
}
