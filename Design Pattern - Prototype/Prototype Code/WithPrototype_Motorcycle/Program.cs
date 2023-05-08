// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        // prototype-nya
        Motorcycle motorcycle1 = new Motorcycle("Suzuki", 
                                                "GSXR-150", 
                                                "Hitam", 
                                                2019, 
                                                "123456789", 
                                                "987654321", 
                                                "IRC", 
                                                "1234", 
                                                30000000);
        
        System.Console.WriteLine("\nisi dari motorcycle1:");
        motorcycle1.PrintInfo();

        // clone dari motorcycle1
        System.Console.WriteLine("\nisi dari motorcycle2:");
        Motorcycle motorcycle2 = (Motorcycle)motorcycle1.Clone();
        motorcycle2.ImmobilizerPin = "2345";
        motorcycle2.PrintInfo();

        System.Console.WriteLine("\nisi dari motorcycle1 lagi:");
        motorcycle1.PrintInfo();
    }
}

public class Motorcycle : ICloneable
{
    public string brand;
    public string model;
    public string warna;
    public int tahunPembuatan;
    public string nomorRangka;
    public string nomorMesin;
    public string merkBan;
    public string ImmobilizerPin;
    public int harga;
    public int Price;
    
    public Motorcycle(string brand, string model, string warna, int tahunPembuatan, string nomorRangka, string nomorMesin, string merkBan, string ImmobilizerPin, int harga)
    {
        this.brand = brand;
        this.model = model;
        this.warna = warna;
        this.tahunPembuatan = tahunPembuatan;
        this.nomorRangka = nomorRangka;
        this.nomorMesin = nomorMesin;
        this.merkBan = merkBan;
        this.ImmobilizerPin = ImmobilizerPin;
        this.harga = harga;
    }

    public object Clone()
    {
        // Shallow copy
        return MemberwiseClone();

        //Deep copy
        // return new Motorcycle
        // {
        //     brand = brand,
        //     model = model,
        //     warna = warna,
        //     tahunPembuatan = tahunPembuatan,
        //     nomorRangka = nomorRangka,
        //     nomorMesin = nomorMesin,
        //     merkBan = merkBan,
        //     ImmobilizerPin = ImmobilizerPin,
        //     harga = harga
        // };
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Brand: {brand}\nModel: {model}\nWarna: {warna}\nTahun Pembuatan: {tahunPembuatan}\nNomor Rangka: {nomorRangka}\nNomor Mesin: {nomorMesin}\nMerk Ban: {merkBan}\nImmobilizer Pin: {ImmobilizerPin}\nHarga: {harga}");
    }
}
