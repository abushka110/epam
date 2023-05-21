using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int[] array = { 5, 10, 15, 20, 25 };

        int max = array.Max();
        Console.WriteLine("Maximum value: " + max);
    }
}