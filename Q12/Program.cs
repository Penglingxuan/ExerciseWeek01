using System;

public class Program
{
    public static void Main()
    {
        for (int i = 1; i <= 9; i++)
        {
            for (int j = 1; j <= 9; j++)
            {
                Console.Write($"{i}*{j} = {i * j} ");
            }
            Console.WriteLine();
        }
    }
}

