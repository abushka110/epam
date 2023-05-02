using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Write notebook price:");
        double notebookPrice = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Write pen price: ");
        double penPrice = double.Parse(Console.ReadLine());

        Console.WriteLine("How many notebooks to buy: ");
        int notebookCount = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("How many pens to buy: ");
        int penCount = Convert.ToInt32(Console.ReadLine());

        double copyBookSumPrice = notebookPrice * notebookCount;
        double penSumPrice = penPrice * penCount;
        double fullPrice = copyBookSumPrice + penSumPrice;

        Console.WriteLine($"Total price of {notebookCount} notebooks and {penCount} pens is: {fullPrice}");
    }
}