using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Console.Write("Write number: ");
        string number = Console.ReadLine();

        Console.WriteLine($"Highest possible number with reordered digits: {string.Concat(number.OrderByDescending(c => c))}");
    }
}
