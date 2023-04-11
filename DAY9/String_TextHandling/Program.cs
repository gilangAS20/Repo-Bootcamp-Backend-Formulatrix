// See https://aka.ms/new-console-template for more information
using System;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;

namespace StringTextHandling
{
    class Program
    {
        static void Main()
        {
            //Constructing string
            Console.WriteLine("===Constructing string===");
            string fox = "quick brown jump over the lazy dog";
            Console.WriteLine("fox.EndsWith('dog'): " + fox.EndsWith("dog"));
            Console.WriteLine("fox.StartsWith('quick'): " + fox.StartsWith("quick"));
            Console.WriteLine("fox.Contains('ju'): " + fox.Contains("ju"));
            
            string someText = "%$#*jehfe wjfew";
            Console.WriteLine("%$#*jehf ew,jfew".IndexOfAny (new char[] { '#', ',' })); // char '#' berada di index 2
            Console.WriteLine("ab,cd ef".IndexOfAny (new char[] {' ', ','} )); // 2
            Console.WriteLine("========================= \n\n");

            //Null and Empty Strings
            Console.WriteLine("===Null and Empty Strings===");
            string EmptyString = string.Empty;
            string kosong = string.Empty;
            string EmptyString2 = "";
            string kosong2 = null;
            Console.WriteLine(EmptyString == EmptyString2);
            Console.WriteLine(EmptyString2 == "");
            Console.WriteLine(EmptyString2 == " ");
            Console.WriteLine(new string('*', 10));
            Console.WriteLine((new string('*', 10).Length));

            char[] hello = "hello".ToCharArray();
            foreach (char c in hello)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine(hello);

            char[] ca = "gilang".ToCharArray();
            string s = new string(ca);
            System.Console.WriteLine(s);
            System.Console.WriteLine(ca[0]);
            System.Console.WriteLine(ca.Length);
            System.Console.WriteLine(s.Length);
            System.Console.WriteLine(EmptyString2.Length == 0);
            System.Console.WriteLine(kosong == null);
            System.Console.WriteLine(kosong2 == null);
            Console.WriteLine("========================= \n\n");

            //Access character within string
            Console.WriteLine("===Access character within string===");
            Console.WriteLine(new string('a', 10));

            char[] charArray = "formulatrix".ToCharArray();
            foreach(char nilai in charArray)
            {
                System.Console.Write(nilai);
            }
            for(int i = 0; i < charArray.Length; i++)
            {
                System.Console.Write(charArray[i]);
            }
            System.Console.WriteLine("\n================================== \n\n");

            //Searching within string
            Console.WriteLine("===Searching within string===");

            string text = "The quick brown fox jumps over the lazy dog";
            System.Console.WriteLine(text.Contains("fox"));
            System.Console.WriteLine(text.Contains(" "));
            System.Console.WriteLine(text.Contains("welfkjewnjfne"));
            System.Console.WriteLine(text.StartsWith("t".ToUpper()));

            string password = "pA5W0rdd";
            int cekIn = password.IndexOfAny(new char[] {'p', 'z'});
            System.Console.WriteLine(password.IndexOfAny(new char[] {'a', 'z'}));
            Console.WriteLine(cekIn);

            if(cekIn == -1)
            {
                System.Console.WriteLine("karakter di password tidak ditemukan");
            }
            else
            {
                System.Console.WriteLine("karakter di password ditemukan pada index ke-" + cekIn);
            }

            System.Console.WriteLine("================================== \n\n");

            //Manipulating string
            Console.WriteLine("===Manipulating string===");
            string _ = "       *     anjAY sLeBew Yuhu     *      ";

            System.Console.WriteLine(_);
            System.Console.WriteLine(_.Trim());
            System.Console.WriteLine(_.TrimStart());
            System.Console.WriteLine(_.TrimEnd());
            System.Console.WriteLine(_.PadRight(50, '%'));
            System.Console.WriteLine(_.ToLower());
            System.Console.WriteLine(_.ToUpper());
            System.Console.WriteLine(_.Substring(0, 20));
            System.Console.WriteLine(_.ToUpperInvariant());
            System.Console.WriteLine(_.ToLowerInvariant());
            System.Console.WriteLine(_.Replace(" ", "^"));

            Console.WriteLine("\n========================= \n\n");

            //String.Format
            Console.WriteLine("===String.Format===");

            string composite = string.Format("Hello {0, 2}, your balance is {1,2:C} ", "Gilang", 123.45);
            System.Console.WriteLine(composite);

            Console.WriteLine("========================= \n\n");


            // String Order Comparison
            Console.WriteLine("===String Order Comparison===");
            System.Console.WriteLine("a".CompareTo("b"));
            System.Console.WriteLine("Banana".CompareTo("Apple"));
            System.Console.WriteLine("Banana".CompareTo("Banana"));

            Console.WriteLine("========================= \n\n");

            //String Builder
            Console.WriteLine("===String Builder===");
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello");
            sb.Append(" ");
            sb.Append("World");
            System.Console.WriteLine(sb);
            Console.WriteLine("========================= \n\n");

            decimal a = 0.1m; // untuk penggunaan operasi matematika yang akurat
            decimal b = 0.2m;
            System.Console.WriteLine(a + b);
            System.Console.WriteLine(a+b == 0.3m);


        }
    }
}
