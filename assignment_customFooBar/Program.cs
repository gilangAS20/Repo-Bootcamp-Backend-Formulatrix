// See https://aka.ms/new-console-template for more information
using System;
using System.Text;
using System.Diagnostics;
// in file "Program.cs"
namespace CustomFooBar;

    class Program
    {
        public static void Main()
        {
            Operation coba1 = new Operation();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Console.WriteLine(coba1.AddKeyValue(3, "foo")); // tambahkan .Item1/.Item2 untuk menampilkan salah satu(hasil / boolean)
            Console.WriteLine(coba1.AddKeyValue(5, "bar"));
            Console.WriteLine(coba1.AddKeyValue(7, "zoo"));
            Console.WriteLine(coba1.DisplayDict());

            Console.WriteLine(coba1.RemoveDict(3).Item2); // tambahkan .Item1/.Item2 untuk menampilkan salah satu(hasil / boolean)
            Console.WriteLine(coba1.RemoveDict(5));
            Console.WriteLine(coba1.RemoveDict(9));

            Console.WriteLine(coba1.AddKeyValue(3, "foo"));
            Console.WriteLine(coba1.AddKeyValue(5, "bar"));
            Console.WriteLine(coba1.DisplayDict());
            Console.WriteLine(coba1.DisplayChange(35)); //input angka 35 (0 s/d 35)

            Console.WriteLine(coba1.AddKeyValue(7, "haha"));
            Console.WriteLine(coba1.DisplayDict());

            Console.WriteLine(coba1.RemoveDict(12));

            Console.WriteLine(coba1.DisplayChange(35)); //input angka 35 (0 s/d 35)

            Console.WriteLine(coba1.Exit());

            stopwatch.Stop();
            Console.WriteLine($"Time: {stopwatch.Elapsed.TotalMilliseconds} ms");
        }
    }

