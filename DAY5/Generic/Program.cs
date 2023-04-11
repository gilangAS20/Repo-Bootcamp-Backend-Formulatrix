// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

/*
 namespace myProgram
 {
    public class Program
    {
        static void Main()
        {
            MyGenericClass<int> myGenericClassInt = new MyGenericClass<int>(10);
            Console.WriteLine(myGenericClassInt.GetVariable());

            MyGenericClass<double> myGenericClassString = new MyGenericClass<double>(12.7);
            Console.WriteLine(myGenericClassString.GetVariable());

            MyGenericClass<string> myGenericClassDouble = new MyGenericClass<string>("Hello World");
            Console.WriteLine(myGenericClassDouble.GetVariable());
        }

    }

    public class MyGenericClass<T>
    {
        //public T myVariable;
        private readonly T myVariable1;
        private T myVariable2;

        public MyGenericClass(T value)
        {
            myVariable2 = value;
        }

        
        public T GetVariable()
        {
            return myVariable2;
        }
        
    }
 }
 */
/*
namespace TryGeneric
{
    public class Program
    {
        static void Main()
        {
            Pair<string, string> pair1 = new("10", "Hello World");
            Console.WriteLine(pair1.GetPair());
        }
    }

    public class Pair<T, U>
    {
        public T First { get; set;}
        public U Second { get; set; }

        public Pair (T first, U second)
        {
            First = first;
            Second = second;
        }

        public string GetPair()
        {
            return $"First: {First}, Second: {Second}";
        }
    }

}
*/
/*
namespace Coba
{
    public class Program
    {
        public static void Main()
        {
            MyGenericCar genericCar = new MyGenericCar();
            Car car = genericCar.myMethod();
            Console.WriteLine($"brand: {car.namaBrand}, model: {car.namaModel}, tahun: {car.tahun}");
        }

    }

    public class Car
    {
        public string namaBrand { get; set; }
        public string namaModel { get; set; }
        public int tahun { get; set; }

        public Car(string NamaBrand, string NamaModel,  int Ntahun)
        {
            namaBrand = NamaBrand;
            namaModel = NamaModel;
            tahun = Ntahun;
        }

    }

    public class MyGenericCar
    {
        public Car myMethod()
        {
            Car car = new("Toyota", "Avanza", 2010);
            return car;
        }
    }
}
*/

namespace myProgram;

class Program {
    static void Main() {
        Automobile myAuto = new Automobile();
        CarDescription Toyota = myAuto.MyMethod(4, 4);
        Console.WriteLine(Toyota.NumberOfDoors);
        Console.WriteLine(Toyota.NumberOfWheels);


        //CarDescription Honda = new CarDescription();
        //myAuto.CarEditor(Honda);
    }
}
class Automobile {
    public Automobile() {
        Console.WriteLine("Automobile constructor");
    }
    public CarDescription MyMethod(int numberOfDoors, int numberOfWheels)
    {
        CarDescription myCar = new();
        myCar.NumberOfDoors = numberOfDoors;
        myCar.NumberOfWheels = numberOfWheels;
        return myCar;
    }

    public CarDescription CarEditor(CarDescription carDescriptionx) {
        carDescriptionx.NumberOfDoors = 5;
        carDescriptionx.NumberOfWheels = 5;
        return carDescriptionx;
    }

}

class CarDescription {
    public int NumberOfDoors { get; set; }
    public int NumberOfWheels { get; set; }
    public CarDescription() {
        Console.WriteLine("Car constructor");
    }
}