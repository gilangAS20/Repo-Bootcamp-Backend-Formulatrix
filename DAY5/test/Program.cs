// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

namespace Test;

class Program
{
    static void Main()
    {
        BangunMobil toyota = new();
        SpekMobil avanza = toyota.MyMethod(4, 4);
        SpekMobil rush = toyota.EditCar(avanza);
        Console.WriteLine(rush.JumlahKursi);
        Console.WriteLine(rush.JumlahRoda);
        Console.WriteLine("=============");
        Console.WriteLine(avanza.JumlahRoda);
        Console.WriteLine(avanza.JumlahKursi);
    }
}

class BangunMobil
{
    public SpekMobil MyMethod(int jmlRoda, int jmlKursi) 
    {
        SpekMobil mobilSpec = new();
        mobilSpec.JumlahRoda = jmlRoda;
        mobilSpec.JumlahKursi = jmlKursi;
        return mobilSpec;
    }

    public SpekMobil EditCar( SpekMobil SpekMobilHaha)
    {
        SpekMobilHaha.JumlahRoda = 10;
        SpekMobilHaha.JumlahKursi = 12;
        return SpekMobilHaha;
    }
}


class SpekMobil
{
    public int JumlahRoda {get ; set;}
    public int JumlahKursi {get ; set;}
}
