// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

namespace TesGenericIntance;

class Program
{
    static void Main()
    {

    }
}

class GenericOnlineShop
{
    public string ProductName { get; set;}
    public string ProductPrice {get; set;}

    public GenericOnlineShop(string ProductName, string ProductPrice)
    {
        ProductName = productName;
        ProductPrice = productPrice;
    }
}

class ProductFood
{
    public string Name { get; set;}
    public int Price { get; set;}
    public int Quantity {get; set;}
    public string Description {get; set;}

    public ProductFood()
    {
        Console.WriteLine("constructor class ProductFood");
    }
}

