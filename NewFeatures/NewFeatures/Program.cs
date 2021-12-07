// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Obi Oberoi!!!");

var today = DateOnly.FromDateTime(DateTime.Now);
Console.WriteLine($"The date is: {today}");

var currTime = TimeOnly.FromDateTime(DateTime.Now);
Console.WriteLine($"The time is: {currTime}");

Console.ReadLine();
