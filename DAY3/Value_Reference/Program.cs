using System;

namespace ValueAndReference
{
    class Program
    {
        public static void Main()
        {
            int x = 5;
            int y = x;
            x = 10;

            Console.WriteLine(x);
            Console.WriteLine(y);

            Person gilang = new Person();
            Console.WriteLine("nama diambil dari class Person: " + gilang.Name);

            gilang.Name = "Gilang"; // mengubah value Name dari class Person
            Console.WriteLine("gilang.Name diganti menjadi 'Gilang': " + gilang.Name);

            Person agung = gilang; // membuat object baru dengan value dari object gilang
            Console.WriteLine("Person 'agung' mengambil referensi dari 'Person gilang' : " + agung.Name);
            
            agung.Name = "Agungs"; // mengubah value Name dari class Person menjadi "Agungs"
            Console.WriteLine("agung.Name dengan referensi 'Person gilang' diganti menjadi 'Agungs': " + agung.Name);

            Console.WriteLine(gilang.Name); // nilai object 'gilang' ikut terganti menjadi "Agungs"
            Console.WriteLine(agung.Name); // yang ini tetap 'Agungs'
        }
    }

    class Person
    {
        public string Name = "slebew";
    }
}
