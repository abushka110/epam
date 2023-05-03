using System;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Скільки кошутє зошит? ");
        double notebookPrice = double.Parse(Console.ReadLine());

        Console.WriteLine("Скільки кошутє ручка? ");
        double penPrice = double.Parse(Console.ReadLine());

        Console.WriteLine("Скільки зошитів потрібно? ");
        int notebookCount = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Скільки ручок потрібно? ");
        int penCount = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Скільки грошей маєте?");
        double howMuchMoney = double.Parse(Console.ReadLine());

        double fullPrice = notebookPrice * notebookCount + penPrice * penCount;

        if (howMuchMoney > fullPrice)
        {
            Console.WriteLine($"Якщо купити {notebookCount} зошитів і {penCount} ручок в вас залишиться {howMuchMoney % fullPrice}грн");
        }
        else
        {
            Console.WriteLine($"Вам не вистачить грошей на {notebookCount} зошитів і {penCount} ручок");
        }
    }
}