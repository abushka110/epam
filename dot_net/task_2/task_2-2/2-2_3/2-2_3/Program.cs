using System;

class Program
{
    static void Main(string[] args)
    {
        int number, firstNumber, secondNumber, thirdNumber, temp;

        Console.WriteLine("Enter a three-digit number:");
        number = Convert.ToInt32(Console.ReadLine());
        firstNumber = number / 100;
        secondNumber = number / 10 % 10;
        thirdNumber = number % 10;

        if (firstNumber < secondNumber)
        {
            temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;
        }

        if (secondNumber < thirdNumber)
        {
            temp = secondNumber;
            secondNumber = thirdNumber;
            thirdNumber = temp;
        }

        if (firstNumber < secondNumber)
        {
            temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;
        }

        number = firstNumber * 100 + secondNumber * 10 + thirdNumber;
        Console.WriteLine($"Maximum number is: {number}");
    }
}