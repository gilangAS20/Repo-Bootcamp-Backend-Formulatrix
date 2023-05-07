// See https://aka.ms/new-console-template for more information
using Humanizer;

Console.WriteLine("Hello, World!");

static void HumanizeQuantities()
{
    System.Console.WriteLine("I have activity".ToQuantity(7));
    System.Console.WriteLine("car".ToQuantity(7));
    System.Console.WriteLine("goose".ToQuantity(7));
}



static void HumanizeDate()
{
    System.Console.WriteLine(DateTime.UtcNow.AddHours(-24).Humanize());
    System.Console.WriteLine(DateTime.UtcNow.AddHours(-2).Humanize());
    System.Console.WriteLine(DateTime.UtcNow.AddHours(+1).Humanize());

    System.Console.WriteLine(TimeSpan.FromDays(1).Humanize());
    System.Console.WriteLine(TimeSpan.FromDays(7).Humanize());
    System.Console.WriteLine(TimeSpan.FromDays(14).Humanize());
    System.Console.WriteLine(TimeSpan.FromHours(5).Humanize());
}


System.Console.WriteLine("Quantities: ");
HumanizeQuantities();

System.Console.WriteLine("\n");
HumanizeDate();
