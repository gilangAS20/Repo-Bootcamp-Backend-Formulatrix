// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections;

/*
namespace TryEnum
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("hehe");

            foreach(Hari i in Enum.GetValues(typeof(Hari))) // menampilkan seluruh hari
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine("");
            int Score = (int) Hari.Jumat;
            Console.WriteLine("Score: " + Score);

            Hari ChoosenDay = Hari.Senin;
            Console.WriteLine(ChoosenDay);



            
            


        }

        enum Hari
        {
            Senin = 1,
            Selasa = 7,
            Rabu = 6,
            Kamis = 5,
            Jumat = 4,
            Sabtu = 3,
            Minggu = 2
        }

        enum Days
        {
            Senin,
            Selasa,
            Rabu,
            Kamis,
            jumat
        }
    }
}
*/


class TryEnum
{
    class Program
    {
        static void Main()
        {

        }
    }

   public class MySequence : IEnumerable
   {
        public int[] data = {1,2,3,4,5};

        public IEnumerator GetEnumerator()
   }
}