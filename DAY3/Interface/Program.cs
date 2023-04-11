// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

public class Program
{
    public static void Main()
    {
        Car SUV = new Car();

        Console.WriteLine("Masukkan jumlah roda: ");
        int wheel = Convert.ToInt32(Console.ReadLine());
        SUV.WheelCount(wheel);
        SUV.MoveForward();
        SUV.MoveBackward();
        Console.WriteLine("Masukkan kecepatan: ");
        int speed = Convert.ToInt32(Console.ReadLine());
        SUV.Accelerate(speed);
        SUV.Stop();
    }

    public interface ICar
    {
        void MoveForward();
        void MoveBackward();
        void Accelerate(int speed);
        void Stop();
    }

    public interface IWheel
    {
        void WheelCount(int wheel);
    }
    

    public class Car : ICar
    {
        public void MoveForward()
        {
            Console.WriteLine("Mobil bergerak ke depan");
        }

        public void MoveBackward()
        {
            Console.WriteLine("Mobil bergerak ke belakang");
        }

        public void Accelerate(int speed)
        {
            Console.WriteLine($"Mobil bergerak dengan kecepatan {speed} km/jam");
        }
        public void Stop()
        {
            Console.WriteLine("Mobil berhenti");
        }

        public void WheelCount(int wheel)
        {
            Console.WriteLine($"Mobil memiliki {wheel} roda");
        }
    }
}

