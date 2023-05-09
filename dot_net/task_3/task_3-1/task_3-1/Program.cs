using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number A: ");
        int A = int.Parse(Console.ReadLine());

        Console.Write("Enter a number B: ");
        int B = int.Parse(Console.ReadLine());

        for (int i = A; i >= B; i--)
        {
            Console.WriteLine(i);
        }

        Console.ReadKey();
    }
}