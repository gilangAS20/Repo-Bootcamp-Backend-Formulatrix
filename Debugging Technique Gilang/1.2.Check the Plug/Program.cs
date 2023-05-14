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
        Console.WriteLine(DateTime.UtcNow.AddHours(-24).Humanize()); // output: yesterday
        Console.WriteLine(DateTime.UtcNow.AddHours(-2).Humanize()); // output: 2 hours ago
        Console.WriteLine(DateTime.UtcNow.AddHours(+1).Humanize()); // output: 59 minutes from now

        Console.WriteLine(TimeSpan.FromDays(1).Humanize()); // output: 1 day
        Console.WriteLine(TimeSpan.FromDays(7).Humanize()); // output: 1 week
        Console.WriteLine(TimeSpan.FromDays(14).Humanize()); // output: 2 weeks
        Console.WriteLine(TimeSpan.FromHours(5).Humanize()); // output: 5 hours
    }
}
