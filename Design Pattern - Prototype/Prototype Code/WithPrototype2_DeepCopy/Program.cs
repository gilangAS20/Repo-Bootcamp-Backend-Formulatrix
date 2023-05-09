// See https://aka.ms/new-console-template for more information
using System;

public class Client
{
    static void Main(string[] args)
    {
        // Create prototype object
        Person prototype = new Person
        {
            Name = "Gilang",
            Address = new Address // kunci dari deep copy
            {
                City = "Salatiga",
                Country = "Indonesia"
            }
        };

        // Shallow copy
        System.Console.WriteLine("isi dari prototype(awal):");
        prototype.PrintInfo();

        System.Console.WriteLine("========================================");
        
        //Person person2 = (Person)prototype.Clone();
        Person person2 = prototype.Clone();
        person2.Name = "Agung";
        person2.Address.City = "San Francisco";
        System.Console.WriteLine("isi dari shallowCopy:");
        person2.PrintInfo(); // Output: Name: John, Address: San Francisco, USA

        System.Console.WriteLine("========================================");

        System.Console.WriteLine("isi dari prototype(setelah instance 2 ganti isi):");
        prototype.PrintInfo(); // Output: Name: John, Address: San Francisco, USA (Changed due to shallow copy)
        
        System.Console.WriteLine("========================================");
        

        // output
        // Name: John, Address: San Francisco, USA
        // Name: John, Address: New York, USA
    }
}


public class Person //: ICloneable
//public class Person : ICloneable
{
    public string Name;
    public Address Address;

    //public Person Clone()
    public Person Clone()
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


