using System;

public class program
{
    public static void Main()
    {
        int num, n1, n2, n3;

        num = Convert.ToInt32(Console.ReadLine());
        n1 = num / 100;
        n2 = num % 100 / 10;
        n3 = num % 10;

        if (n1 >= n2 & n1 >= n3)
            if (n2 > n3)
                Console.WriteLine(num);
            else
                Console.WriteLine(n1 * 100 + n3 * 10 + n2);
        else if (n2 >= n1 & n2 >= n3)
            if (n1 > n3)
                Console.WriteLine(n2 * 100 + n1 * 10 + n3);
            else
                Console.WriteLine(n2 * 100 + n3 + 10 + n1);
        else if (n2 > n1)
            Console.WriteLine(n3 * 100 + n2 * 10 + n1);
        else
            Console.WriteLine(n3 * 100 + n1 * 10 + n2);
    }
}
