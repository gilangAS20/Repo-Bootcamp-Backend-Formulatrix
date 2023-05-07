using System;

// Client code
class Client
{
    static void Main(string[] args)
    {
        // Create prototype object
        System.Console.WriteLine("Instance 1:");
        Car prototypeCar = new Car("Toyota", "Corolla");
        prototypeCar.PrintInfo();

        // Clone object
        System.Console.WriteLine("\nInstance 2:");
        Car newCar = (Car)prototypeCar.Clone();
        newCar.PrintInfo(); // Output: Brand: Toyota, Model: Corolla

        // Modify cloned object
        System.Console.WriteLine("\nInstance 3:");
        newCar.SetBrand("Honda");
        newCar.SetModel("Civic");
        newCar.PrintInfo(); // Output: Brand: Honda, Model: Civic

        // make third instance
        System.Console.WriteLine("\nInstance 4:");
        Car newCarOne = new Car(prototypeCar.GetBrand(), prototypeCar.GetModel());
        newCarOne.PrintInfo();

        /*
        System.Console.WriteLine("\nChane Instance 4 become:");
        newCarOne.SetBrand("Hyundai");
        newCarOne.SetBrand("Kona electric");
        newCarOne.PrintInfo();
        */

        System.Console.WriteLine("\nEdit Instance 1 and print it: ");
        prototypeCar.SetBrand("Cherry");
        prototypeCar.SetModel("Tigo");

        System.Console.WriteLine("Show instance 4 again:");
        newCarOne.PrintInfo();
    }
}


// Prototype interface
public interface IPrototype
{
    IPrototype Clone();
}

// Concrete prototype
public class Car : IPrototype
{
    private string _brand;
    private string _model;

    public Car(string brand, string model)
    {
        _brand = brand;
        _model = model;
    }

    // Clone method implementation
    public IPrototype Clone()
    {
        return new Car(_brand, _model);
    }

    public void SetBrand(string brand)
    {
        _brand = brand;
    }

    public void SetModel(string model)
    {
        _model = model;
    }

    public string GetBrand()
    {
        return _brand;
    }

    public string GetModel()
    {
        return _model;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Brand: {_brand}, Model: {_model}");
    }
}
