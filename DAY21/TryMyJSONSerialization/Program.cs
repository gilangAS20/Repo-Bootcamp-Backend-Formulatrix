// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Text.Json;

namespace TryJSONSerialization
{
    class Program
    {
        static void Main()
        {
            System.Console.WriteLine("Masukkan jumlah data yang ingin diinputkan: ");
            int jmlData = int.Parse(Console.ReadLine());

            Person[] person = new Person[jmlData];

            for (int i = 0; i < jmlData; i++)
            {
                person[i] = new Person();
                System.Console.WriteLine("Masukkan nama: ");
                person[i].Name = Console.ReadLine();
                System.Console.WriteLine("Masukkan umur: ");
                person[i].Age = int.Parse(Console.ReadLine());
            }

            System.Console.WriteLine("Data yang telah diinputkan: ");
            for (int i = 0; i < jmlData; i++)
            {
                System.Console.WriteLine($"Name: {person[i].Name}, Age: {person[i].Age}");
            }

            // serialize the object
            System.Console.WriteLine("--serialize the object--");
            string json = JsonSerializer.Serialize(person);
            File.WriteAllText("person.json", json);
            System.Console.WriteLine(json);

            // deserialize the object
            System.Console.WriteLine("--deserialize the object--");
            string jsonFromFile = File.ReadAllText("person.json");
            Person[] deserializedPerson = JsonSerializer.Deserialize<Person[]>(jsonFromFile);
            System.Console.WriteLine("Data yang telah diinputkan: ");
            for (int i = 0; i < jmlData; i++)
            {
                System.Console.WriteLine($"Name: {deserializedPerson[i].Name}, Age: {deserializedPerson[i].Age}");
            }
        }
    }

    public class Person
    {
        public string? Name { get; set; }
        public int? Age { get; set; }
    }
}
