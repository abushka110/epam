using System;

class Program
{
    static void Main()
    {
        int[,] matrix = {
            { 2, 4, 8, 1, 5 },
            { 6, 3, 7, 2, 1 },
            { 7, 1, 6, 2, 4 }
        };

        int rows = matrix.GetLength(0);

        int maxSum = 0;
        int maxSumRowIndex = 0;

        for (int i = 0; i < rows; i++)
        {
            int sum = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                sum += matrix[i, j];
            }

            if (sum > maxSum)
            {
                maxSum = sum;
                maxSumRowIndex = i;
            }
        }

        Console.WriteLine("Line number has the maximum number of elements: " + maxSumRowIndex);
    }
}