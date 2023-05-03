using System;
public class Program
{
    public static void Main()
    {
        int notebookCount, penCount;
        double notebookPrice, penPrice, howMuchMoney, fullPrice;

        Console.WriteLine("Enter the price of the notebook: ");
        notebookPrice = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the price of the pen: ");
        penPrice = double.Parse(Console.ReadLine());

        Console.WriteLine("How many notebooks do you need?? ");
        notebookCount = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("How many pens do you need? ");
        penCount = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("How much money do you have?");
        howMuchMoney = double.Parse(Console.ReadLine());

        fullPrice = notebookPrice * notebookCount + penPrice * penCount;

        if (howMuchMoney > fullPrice)
        {
            Console.WriteLine($"If you buy {notebookCount} copybooks and {penCount} pens, you will have {howMuchMoney % fullPrice}UAH left");
        }
        else
        {
            Console.WriteLine($"You don't have enough money to buy {notebookCount} copybooks and {penCount} pens");
        }
    }
}