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
        Person shallowCopy = (Person)prototype.Clone();
        shallowCopy.Address.City = "San Francisco";
        shallowCopy.PrintInfo(); // Output: Name: John, Address: San Francisco, USA
        prototype.PrintInfo(); // Output: Name: John, Address: San Francisco, USA (Changed due to shallow copy)

        // Deep copy
        Person deepCopy = (Person)prototype.Clone();
        deepCopy.Address.City = "Los Angeles";
        deepCopy.PrintInfo(); // Output: Name: John, Address: Los Angeles, USA
        prototype.PrintInfo(); // Output: Name: John, Address: San Francisco, USA (Unchanged due to deep copy)

        // output
        // Name: John, Address: San Francisco, USA
        // Name: John, Address: New York, USA
        // Name: John, Address: Los Angeles, USA
        // Name: John, Address: New York, USA
    }
}


public class Person : ICloneable
{
    public string Name;
    public Address Address;

    public object Clone()
    {
        // Shallow copy
        //return MemberwiseClone();

        //Deep copy
        return new Person
        {
            Name = Name,
            Address = new Address
            {
                City = Address.City,
                Country = Address.Country
            }
        };
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


