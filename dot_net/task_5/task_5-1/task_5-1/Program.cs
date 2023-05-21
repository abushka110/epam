using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter the first integer: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second integer: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        double average = CalculateAverage(number1, number2);
        Console.WriteLine("Arithmetic mean value: " + average);
    }

    public static double CalculateAverage(int num1, int num2)
    {
        return (num1 + num2) / 2.0;
    }
}