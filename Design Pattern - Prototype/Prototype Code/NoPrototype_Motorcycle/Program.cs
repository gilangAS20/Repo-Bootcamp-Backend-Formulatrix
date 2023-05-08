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
        Motorcycle motorcycle2 = new Motorcycle(motorcycle1.brand, 
                                                motorcycle1.model, 
                                                motorcycle1.warna, 
                                                motorcycle1.tahunPembuatan, 
                                                motorcycle1.nomorRangka, 
                                                motorcycle1.nomorMesin, 
                                                motorcycle1.merkBan, 
                                                motorcycle1.ImmobilizerPin, 
                                                motorcycle1.harga);
        
        System.Console.WriteLine("\nisi dari motorcycle2:");
        motorcycle2.PrintInfo();
    }
}

public class Motorcycle
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

    public void PrintInfo()
    {
        Console.WriteLine($"Brand: {brand}\nModel: {model}\nWarna: {warna}\nTahun Pembuatan: {tahunPembuatan}\nNomor Rangka: {nomorRangka}\nNomor Mesin: {nomorMesin}\nMerk Ban: {merkBan}\nImmobilizer Pin: {ImmobilizerPin}\nHarga: {harga}");
    }
}
