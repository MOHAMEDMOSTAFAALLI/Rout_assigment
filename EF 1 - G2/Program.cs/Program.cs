using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Program Started!");

        Aircraft a = new Aircraft
        {
            Id = 1,
            Model = "Airbus A320",
            Capacity = 150
        };

        Console.WriteLine($"Aircraft Model = {a.Model}, Capacity = {a.Capacity}");
    }
}
