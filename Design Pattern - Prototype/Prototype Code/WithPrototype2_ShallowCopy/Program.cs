// See https://aka.ms/new-console-template for more information
using System;

public class Client
{
    static void Main(string[] args)
    {
        // Create prototype object
        Person prototype = new Person
        {
            Name = "John",
            Address = new Address
            {
                City = "New York",
                Country = "USA"
            }
        };

        // Shallow copy
        System.Console.WriteLine("========================================");
        Person john1 = (Person)prototype.Clone();
        john1.Address.City = "San Francisco";
        System.Console.WriteLine("isi dari john1:");
        john1.PrintInfo(); // Output: Name: John, Address: San Francisco, USA
        System.Console.WriteLine("isi dari prototype:");
        prototype.PrintInfo(); // Output: Name: John, Address: San Francisco, USA (Changed due to shallow copy)
        System.Console.WriteLine("========================================");

        // output
        // Name: John, Address: San Francisco, USA
        // Name: John, Address: San Francisco, USA
    }
}


public class Person : ICloneable
{
    public string Name;
    public Address Address;

    public object Clone()
    {
        // Shallow copy
        return MemberwiseClone();

        //Deep copy
        // return new Person
        // {
        //     Name = Name,
        //     Address = new Address
        //     {
        //         City = Address.City,
        //         Country = Address.Country
        //     }
        // };
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}, Address: {Address.City}, {Address.Country}");
    }
}

public class Address
{
    public string City;
    public string Country;
}


