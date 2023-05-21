using System;

class Program
{
    static void Main()
    {
        int[,] matrix = {
            { 4, 2, 9 },
            { 7, 5, 1 },
            { 3, 8, 6 }
        };

        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        int minElement = matrix[0, 0];
        int maxElement = matrix[0, 0];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                int currentElement = matrix[i, j];

                if (currentElement < minElement)
                {
                    minElement = currentElement;
                }

                if (currentElement > maxElement)
                {
                    maxElement = currentElement;
                }
            }
        }

        int sum = minElement + maxElement;

        Console.WriteLine("Minimal element: " + minElement);
        Console.WriteLine("Maximum element: " + maxElement);
        Console.WriteLine("The sum of the minimum and maximum elements: " + sum);
    }
}