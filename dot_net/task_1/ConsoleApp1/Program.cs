using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Write notebook price:");
        int notebookPrice = int.Parse(Console.ReadLine());
        Console.WriteLine("How many notebooks to buy: ");
        int notebookCount = int.Parse(Console.ReadLine());

        Console.WriteLine("Write pen price: ");
        int penPrice = int.Parse(Console.ReadLine());
        Console.WriteLine("How many pens to buy: ");
        int penCount = int.Parse(Console.ReadLine());

        int copyBookSumPrice = notebookPrice * notebookCount;
        int penSumPrice = penPrice * penCount;
        int fullPrice = copyBookSumPrice + penSumPrice;

        Console.WriteLine($"Total price of {notebookCount} notebooks and {penCount} pens is: {fullPrice}");
    }
}