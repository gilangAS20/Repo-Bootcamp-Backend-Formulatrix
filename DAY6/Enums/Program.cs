// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace TryEnums;

class Program
{
    static void Main()
    {
        Hari day = Hari.Senin;
        Console.WriteLine(day);
        int nomorHari = (int) Hari.Senin;
        Console.WriteLine(nomorHari);

        int evenNumDay = (int) daysWeek1.Senin;
        Console.WriteLine(evenNumDay);

        int randomNumDay = (int) daysWeek2.Kamis;
        Console.WriteLine(randomNumDay);

        daysWeek3 hariTerpilih = daysWeek3.Senin;

        switch(hariTerpilih)
        {
            case daysWeek3.Senin:
                Console.WriteLine("pilihanmu hari senin");
                break;

            case daysWeek3.Minggu:
                Console.WriteLine("pilihanmu hari minggu");
                break;
        }

        foreach (daysWeek3 listHari in Enum.GetValues(typeof(daysWeek3)))
        {
            Console.Write(listHari + " ");
        }
    }

    enum Hari
    {
        Senin, Selasa, Rabu, Kamis, Jumat, Sabtu, Minggu
        // 0    1       2      3      4       5      6
    }

    enum daysWeek1
    {
        Senin = 2, Selasa = 4, Rabu = 6, Kamis = 8, Jumat = 10, Sabtu = 12, Minggu = 14
    }

    enum daysWeek2
    {
        Senin, Selasa, Rabu = 5, Kamis, Jumat, Sabtu, Minggu
    }

    enum daysWeek3
    {
        Senin, Selasa, Rabu, Kamis, Jumat, Sabtu, Minggu
    }
}