// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Generic instance

namespace MyProgram;

class Program
{
    static void Main()
    {
        GenericAutoMobile<string, string, string> myGenericClassInt = new();
        CarDescription myCar = myGenericClassInt.MyMethod("2", "3");
        Console.WriteLine(myCar.NumberOfDoors);
        Console.WriteLine(myCar.NumberOfWheels);

        GenericAutoMobile<int, int, CarDescription> myGenericClassString = new();
        CarDescription myCar2 = myGenericClassString.MyMethod(2, 3);
        Console.WriteLine(myCar2.NumberOfDoors);

        // GenericAutoMobile<int, int, int> myGenericClassCoba = new();
        // CarDescription myCar3 = myGenericClassCoba.CarEditor(myCar2);
        // Console.WriteLine(myCar3.NumberOfDoors);

      //
        CarDescription myCarX = new();
        myCarX.NumberOfDoors = 4;
        myCarX.NumberOfWheels = 5;
        GenericAutoMobile<int, int, CarDescription> myGenericClassCoba3 = new();
        CarDescription myCar5 = myGenericClassCoba3.CarEditor(myCarX);
        Console.WriteLine(myCar5.NumberOfDoors);
        Console.WriteLine(myCar5.NumberOfWheels);

    }
}

class GenericAutoMobile <TKey, TKey2, TKey3>
{
    public GenericAutoMobile()
    {
        Console.WriteLine("GenericAutoMobile constructor");
    }
    public CarDescription? MyMethod(TKey key, TKey2 key2)
    {
        if((key is int a && key2 is int b)) {
            CarDescription myCar = new();
            myCar.NumberOfDoors = a;
            myCar.NumberOfWheels = b;
            return myCar;
        }
        else if(key is string c && key2 is string d) {
            CarDescription myCar = new();
            myCar.NumberOfDoors = int.Parse(c);
            myCar.NumberOfWheels = int.Parse(d);
            return myCar;
        }
        Console.WriteLine("Invalid input");
        return null;
    }

    public CarDescription? CarEditor(TKey3 key3)
    {
        if(key3 is CarDescription Car)
        {
            Car.NumberOfDoors = 5;
            Car.NumberOfWheels = 6;
            return Car;
        }
        Console.WriteLine("Invalid input");
        return null;
    }
}

public class CarDescription
{
    public int NumberOfDoors { get; set; }
    public int NumberOfWheels { get; set; }
    public CarDescription()
    {
        Console.WriteLine("GenericCar constructor");
    }
}