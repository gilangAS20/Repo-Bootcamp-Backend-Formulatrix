// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Collections;
namespace AssignmentGenericCompotition
{

    public class Program
    {
        public static void Main()
        {
            /*
            MyGenericClass1 inputan1 = new MyGenericClass1();
            inputan1.data = new string[inputan1.capacity];
            inputan1.AddData("gilang");
            inputan1.AddData("agung");
            inputan1.AddData("saputra");
            inputan1.AddData("anjay");
            inputan1.AddData("slebew");
            //inputan1.AddData("uwessss");
            
            //menampilkan data
            foreach (string i in inputan1.GetData())
            {
                //Console.WriteLine("data index ke-" + i);
                Console.WriteLine(i);
            }
            */
            //create instance with capacity 5
            /*
            MyGenericClass1 inputan1 = new MyGenericClass1(5); 
            inputan1.data = new ArrayList(); 

            inputan1.AddData("gilang");
            inputan1.AddData("agung");
            inputan1.AddData("saputra");
            inputan1.AddData("anjay");
            inputan1.AddData("slebew");
            inputan1.AddData("uhuy");
            inputan1.GetData();

            //remove data
            inputan1.RemoveData("agung");

            //menampilkan data
            inputan1.GetData();
            */

            /*
            //create instance with capacity 5
            MyGenericClass1 inputan2 = new MyGenericClass1(5);
            inputan2.data = new ArrayList();

            inputan2.AddData<string>("20");
            inputan2.AddData<string>("gilang");

            inputan2.GetData<string>();
            */

            //create instance with capacity 5
            MyStringClass2 inputan3 = new(5);

            inputan3.AddString("gilang");
            inputan3.AddString("agung");
            inputan3.AddString("saputra");
            inputan3.AddString("anjay");
            inputan3.AddString("slebew");
            inputan3.AddString("uhuy");

            inputan3.GetStringData();

            inputan3.RemoveString("saputra");

            inputan3.GetStringData();
            

            
            
        }
    } // milik public class program

    public class MyGenericClass1<T> // menyimpan bervariasinya tipe data
    {
        public int capacity;
        public ArrayList data;
        public int count = 0;

        public MyGenericClass1(int capacityInput)
        {
            data = new ArrayList();
            capacity = capacityInput;
        }

        public void AddData(T input)
        {

            if (count < capacity)
            {
                data.Add(input);
                count++;
            }
            else
            {
                Console.WriteLine("data penuh");
            }
        }

        public void RemoveData(T dataRemove)
        {
            data.Remove(dataRemove);
            Console.WriteLine($"data '{dataRemove}' berhasil dihapus");
            //GetData();
        }

        public void GetData()
        {
            Console.WriteLine("==data tersimpan: ==");
            foreach(var i in data)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("====================");
        }

    }

    public class MyStringClass2
    {
        public int? capacity2;
        public MyGenericClass1<string> StringData;
        public int count = 0;

        public MyStringClass2(int capacityInput)
        {
            capacity2 = capacityInput;
            StringData = new MyGenericClass1<string>(capacityInput);
        }

        public void AddString(string inputAddString)
        {
            StringData.AddData(inputAddString);
        }

        public void RemoveString(string inputRemoveString)
        {
            StringData.RemoveData(inputRemoveString);
        }

        public void GetStringData()
        {
            StringData.GetData();
        }

    }


}
