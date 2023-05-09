using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number A: ");
        int numberA = int.Parse(Console.ReadLine());

        Console.Write("Enter a number B: ");
        int numberB = int.Parse(Console.ReadLine());

        for (int i = numberA; i >= numberB; i--)
        {
            Console.WriteLine(i);
        }

        Console.ReadKey();
    }
}