// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Obi Oberoi!!!");

var today = DateOnly.FromDateTime(DateTime.Now);
Console.WriteLine($"The date is: {today}");

var currTime = TimeOnly.FromDateTime(DateTime.Now);
Console.WriteLine($"The time is: {currTime}");

int processId = Environment.ProcessId;
#pragma warning disable CS8602 // Dereference of a possibly null reference.
string? myPath = Environment.ProcessPath.ToString();
#pragma warning restore CS8602 // Dereference of a possibly null reference.

Console.WriteLine($"Process Id: {processId} and Path: {myPath}");
Console.ReadLine();
