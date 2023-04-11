// See https://aka.ms/new-console-template for more information
using System;
using System.Text;
using System.Diagnostics;

// TimeSpan
System.Console.WriteLine("===TimeSpan===");
TimeSpan ts1 = new TimeSpan(2, 30, 0);
TimeSpan ts2 = new TimeSpan(1, 0, 0);
TimeSpan ts3 = ts1.Add(ts2);
System.Console.WriteLine(ts1);
System.Console.WriteLine(ts3);

double totalHours = ts1.TotalHours;
System.Console.WriteLine(totalHours);
double totalHours1 = ts3.Hours;
System.Console.WriteLine(ts3);
System.Console.WriteLine(ts3.TotalHours);

System.Console.WriteLine("====================================\n\n");


// DateTime & DateTimeOffset
System.Console.WriteLine("===DateTime & DateTimeOffset===");
string yuhu;
DateTime dt1 = new DateTime(2022, 1, 1, 01,0,0);
Console.WriteLine(dt1);