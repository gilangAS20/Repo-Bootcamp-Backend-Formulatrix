// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

/*
namespace CobaSendiriGeneric
{

    class Program
    {
        static void Main()
        {

            // tes apakah kedua bilangan nilainya sama
            bool ApakahSama = Kalkulator.AreEqual(2, 2);

            if (ApakahSama)
            {
                Console.WriteLine("nilai keduanya sama");
            }
            else
            {
                Console.WriteLine("Nilai keduanya berbeda");
            }
            //=====================================================

            // memunculkan hasil penjumlahan kedua nilai
            int jumlahNilai = Kalkulator.Penjumlahan<int, int> (1,2);
            Console.WriteLine("hasil penjumlahan: " + jumlahNilai);
            //======================================================

            // memunculkan hasil pengurangan kedua nilai
            int kurangNilai = Kalkulator.Pengurangan<int, int> (4, 2);
            Console.WriteLine("hasil pengurangan: " + kurangNilai);
        }
    } // class program

    public class Kalkulator
    {
        public static bool AreEqual <T> (T nilai1, T nilai2)
        {
            if (nilai1.Equals(nilai2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int Penjumlahan <T1, T2> (T1 nilai1, T2 nilai2)
        {
            int hasil = Convert.ToInt32(nilai1) + Convert.ToInt32(nilai2);
            return hasil;
        }
        

        public static int Pengurangan <T3, T4> (T3 value1, T4 value2)
        {
                int hasilKurang = Convert.ToInt32(value1) - Convert.ToInt32(value2);
                return hasilKurang;   
        }
    }

} 
*/

/*
namespace CobaSendiriGeneric2
{
    static class Program
    {
        public static void Main()
        {
            MyGenericClass <int> myGenericClassInt = new MyGenericClass<int> (67);
            int valueGen = myGenericClassInt.GenericMethod(100);
            Console.WriteLine(valueGen);
        }
    }

    class MyGenericClass <T>
    {
        private T GenericMemberVariable;

        public MyGenericClass(T variabel)
        {
            GenericMemberVariable = variabel;
        }

        public T GenericMethod (T GenericParameter)
        {
            Console.WriteLine("Parameter bertipe: " + typeof(T).ToString() + ", dengan nilai: " + GenericParameter);
            Console.WriteLine("Return type: " + typeof(T).ToString() + ", dengan nilai: " + GenericMemberVariable);
            return GenericParameter;
        }
    }
}
*/

namespace CobaSendiriGeneric3;

class Program
{
    static void Main()
    {
        BluePrintMakanan<string, int, PenjelasanMakanan> makanan1 = new BluePrintMakanan<string, int, PenjelasanMakanan>();
        PenjelasanMakanan makanan2 = makanan1.JenisMakanan("piza", 1500);
        Console.WriteLine(makanan2.namaMakanan);
        Console.WriteLine(makanan2.hargaMakanan);

        // mencoba menampilkan nilai di dalam object public PenjelasanMakanan
        PenjelasanMakanan editMakan1 = new PenjelasanMakanan();
        editMakan1.namaMakanan = "nasi";
        editMakan1.hargaMakanan = 2760;
        BluePrintMakanan<int, int, PenjelasanMakanan> editMakan2 = new BluePrintMakanan<int, int, PenjelasanMakanan>();
        PenjelasanMakanan editMakan3 = editMakan2.editMakanan(editMakan1);
        Console.WriteLine("nama makanan edit: " + editMakan3.namaMakanan);
        Console.WriteLine("harga makanan edit: " + editMakan3.hargaMakanan);


        //mengisi nama & harga makanan lalu ditampilkan
        // PenjelasanMakanan masukMakanan = new PenjelasanMakanan();
        // masukMakanan.namaMakanan = "pizzzza";
        // masukMakanan.hargaMakanan = 12760;

        BluePrintMakanan<string, int, PenjelasanMakanan> aksesMakanan = new BluePrintMakanan<string, int, PenjelasanMakanan>();
        PenjelasanMakanan aksesMakanan2 = aksesMakanan.InputMakananBaru ("pizzzza", 325000);
        Console.WriteLine(aksesMakanan2.namaMakanan);
        Console.WriteLine(aksesMakanan2.hargaMakanan); 
    }
}

class BluePrintMakanan <TKey1, TKey2, TKey3>
{
    public BluePrintMakanan()
    {
        Console.WriteLine("Constructor class BluePrintMakanan");
    }

    public PenjelasanMakanan InputMakananBaru (TKey1 nama, TKey2 harga)
    {
        PenjelasanMakanan inputMakan = new PenjelasanMakanan();
        inputMakan.namaMakanan = nama.ToString();
        inputMakan.hargaMakanan = Convert.ToInt32(harga);
        return inputMakan;
    }

    public PenjelasanMakanan JenisMakanan( TKey1 nama, TKey2 harga) //method
    {
        PenjelasanMakanan makanan = new PenjelasanMakanan();
        makanan.namaMakanan = "Klepon";
        makanan.hargaMakanan = 2000;
        return makanan;
    }

    public PenjelasanMakanan editMakanan( TKey3 edit)
    {
        PenjelasanMakanan editmakan = new PenjelasanMakanan();
        editmakan.namaMakanan = "Serabee";
        editmakan.hargaMakanan = 12300;
        return editmakan;
    }
}

public class PenjelasanMakanan
{
    public string? namaMakanan;
    public int? hargaMakanan;

    public PenjelasanMakanan()
    {
        Console.WriteLine("Constructor class PenjelasanMakanan");
    }
}
