using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace TryGC2
{
    class Program
    {
        static void Main()
        {
            System.Console.WriteLine("PERCOBAAN GARBAGE COLLECTOR");
            System.Console.WriteLine("CEK MEMORI YANG DIGUNAKAN");

            
            // cek memori sebelum membuat objek
            System.Console.WriteLine("Memori sebelum membuat objek: {0}", GC.GetTotalMemory(true));
            List<string> myList1 = new List<string>();
            myList1.Add("hello");
            myList1.Add("yuhu");
            myList1.Add("world");

            foreach(var result in myList1)
            {
                System.Console.WriteLine(result);
            }
            System.Console.WriteLine("Memori setelah membuat objek: {0}", GC.GetTotalMemory(true));

            GC.Collect(); // ini tidak disarankan, krena sebenarnya komputer sudah tau kapan harus bersih2
            System.Console.WriteLine("Memori setelah menghapus objek: {0}", GC.GetTotalMemory(true));

            
        }
    }
}
