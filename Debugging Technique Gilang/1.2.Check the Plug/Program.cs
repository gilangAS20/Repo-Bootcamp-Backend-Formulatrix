using Humanizer;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");

        Console.WriteLine("Quantities: ");
        HumanizeQuantities();

        Console.WriteLine("\n");
        HumanizeDate();
    }

    static void HumanizeQuantities()
    {
        Console.WriteLine("I have activity".ToQuantity(7));
        Console.WriteLine("car".ToQuantity(7));
        Console.WriteLine("goose".ToQuantity(7));
    }

    static void HumanizeDate()
    {
        Console.WriteLine(DateTime.UtcNow.AddHours(-24).Humanize());
        Console.WriteLine(DateTime.UtcNow.AddHours(-2).Humanize());
        Console.WriteLine(DateTime.UtcNow.AddHours(+1).Humanize());

        Console.WriteLine(TimeSpan.FromDays(1).Humanize());
        Console.WriteLine(TimeSpan.FromDays(7).Humanize());
        Console.WriteLine(TimeSpan.FromDays(14).Humanize());
        Console.WriteLine(TimeSpan.FromHours(5).Humanize());
    }
}
