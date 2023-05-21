using System;

class Program
{
    static void Main()
    {
        int[] numbers = { -2, 3, 0, 7, -1, 9, 10, -4, 6, -5 };

        int sumOfPositiveNumbers = 0;
        int countOfEvenNumbers = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            int number = numbers[i];

            if (number > 0)
            {
                sumOfPositiveNumbers += number;
            }
            if (number % 2 == 0)
            {
                countOfEvenNumbers++;
            }
        }

        Console.WriteLine("The sum of positive elements: " + sumOfPositiveNumbers);
        Console.WriteLine("The number of even elements: " + countOfEvenNumbers);

        Console.ReadLine();
    }
}