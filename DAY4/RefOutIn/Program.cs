// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//REF-IN-OUT

using System;

/*
namespace RefOutInDemo
{
    static class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            int z = 2;
            int q;

            Add(ref x, ref y);
            Console.WriteLine($"After Add method, x={x}, y={y}");
            
            //Subtract(out x, out y);
            //Console.WriteLine($"After Subcsript method, x={x}, y={y}");

            Subtract(out x, out z);
            Console.WriteLine($"After Subtract method, x={x}, y={z}");

            z = Multiply(in x, in z);
            Console.WriteLine($"After Multiply method, z={z}");

            q = Divide(in x, in z);
            Console.WriteLine($"After Divide method, q = {q}");
        }

        static void Add(ref int a, ref int b)
        {
            a++;
            b++;
        }

        
        static void Subtract(out int a, out int b)
        {
            a = 10;
            b = 20;
            a--;
            b--;
        }
        

        static int Multiply(in int a, in int b)
        {
            return a * b;
        }

        static int Divide(in int a, in int b)
        {
            return a / b;
        }
    }
}
*/


namespace RefDemo
{
    class Program
    {
        static void Main()
        {
            int panjang = 10;
            int lebar = 5;
            int z;
            Console.WriteLine("Nilai int panjang sebelum dipanggil method Tambah: {0}", panjang);
            Console.WriteLine("Nilai int lebar sebelum dipanggil method Tambah: {0}", lebar);


            Console.WriteLine("Hasil method Tambah dengan ref: " + Tambah(ref panjang, ref lebar));
            Console.WriteLine("Nilai int panjang setelah dipanggil method Tambah: {0}", panjang);
            Console.WriteLine("Nilai int lebar setelah dipanggil method Tambah: {0}", lebar);
        }

        static int Tambah(ref int a, ref int b)
        {
            a++;
            b++;
            return a + b;
        }
    }
}


/*
namespace OutDemo
{
    class Program
    {
        static void Main()
        {
            int panjangs; //= 10;
            int lebars; //= 5;
            int z;

            //Console.WriteLine(Tambah(out int panjang, out int lebar));
            Console.WriteLine(Tambah(out panjangs, out lebars));
        }

        static int Tambah(out int a, out int b)
        {
            a = 100;
            b = 34;
            a++;
            b++;

            return a+b;
        }
    }
}
*/


/*
namespace InDemo
{
    class Program
    {
        static void Main()
        {
            int nilaiSatu = 10;
            int nilaiDua = 5;

            Console.WriteLine(Tambah( nilaiSatu,  nilaiDua));
        }

        static int Tambah( int a,  int b)
        {
            a++;
            b++;

            return a+b;
        }
    }
}
*/