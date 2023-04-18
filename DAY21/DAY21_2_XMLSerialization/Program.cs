// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Xml.Serialization;

public class Person
{
    public string? Name { get; set; }
    public int? Age { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person { Name = "Bob", Age = 11 };

        // Serialize the object
        string outerPath = @"../DAY21_1/personTest.xml";
        XmlSerializer serializer = new XmlSerializer(typeof(Person));
        using (StreamWriter writer = new StreamWriter(outerPath))
        {
            serializer.Serialize(writer, person);
        }

        // Deserialize the object
        Person deserializedPerson;
        using (StreamReader reader = new StreamReader("person.xml"))
        {
            deserializedPerson = (Person)serializer.Deserialize(reader);
        }

        Console.WriteLine($"Deserialized Person: {deserializedPerson.Name}, {deserializedPerson.Age}");
    }
}
