public class Program
{
    public static void Main()
    {
        int[,] array = {
            { 1, 3, 2, 4 },
            { 6, 3, 9, 4 },
            { 1, 5, 7, 2 }
        };

        ShiftRowsDown(array);

        Console.WriteLine("Result:");
        PrintArray(array);
    }

    public static void ShiftRowsDown(int[,] array)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        int[] lastRow = new int[columns];
        for (int j = 0; j < columns; j++)
        {
            lastRow[j] = array[rows - 1, j];
        }

        for (int i = rows - 1; i > 0; i--)
        {
            for (int j = 0; j < columns; j++)
            {
                array[i, j] = array[i - 1, j];
            }
        }

        for (int j = 0; j < columns; j++)
        {
            array[0, j] = lastRow[j];
        }
    }

    public static void PrintArray(int[,] array)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}