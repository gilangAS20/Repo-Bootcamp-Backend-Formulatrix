using System;
using System.IO;
using Newtonsoft.Json;

class Program
{
    static void Main()
    {
        /*
        Customer customer1 = new Customer
        {
            Name = "Bob",
            Age = 11,
            Address = "123 Main St"
        };
        */
        System.Console.WriteLine("Masukkan jumlah data yang ingin diinputkan: ");
        int jmlData = int.Parse(Console.ReadLine());

        Customer[] customer = new Customer[jmlData];

        for(int i = 0; i < jmlData; i++)
        {
            customer[i] = new Customer();
            System.Console.WriteLine("Masukkan nama: ");
            customer[i].Name = Console.ReadLine();
            System.Console.WriteLine("Masukkan umur: ");
            customer[i].Age = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Masukkan alamat: ");
            customer[i].Address = Console.ReadLine();
        }

        // serialize
        string myJsonText = JsonConvert.SerializeObject(customer, Formatting.Indented);
        File.WriteAllText("customer.json", myJsonText);
        Console.WriteLine(myJsonText);

        // deserialize
        string jsonFromFile = File.ReadAllText("customer.json");
        Customer[] deserializedCustomer = JsonConvert.DeserializeObject<Customer[]>(jsonFromFile);
        System.Console.WriteLine("Data yang telah diinputkan: ");
        for (int i = 0; i < jmlData; i++)
        {
            System.Console.WriteLine($"Name: {deserializedCustomer[i].Name}, Age: {deserializedCustomer[i].Age}, Address: {deserializedCustomer[i].Address}");
        }

    }
}

public class Customer
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }
}
