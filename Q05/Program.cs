using System;

public class Program
{
    public static void Main()
    {
        int printNum = 5;
        for (int i = 1; i <= 100; i ++)
        {
            if (i % 3 == 0 && i % 5 != 0)
            {
                Console.Write($"{i},");
                printNum ++;
                if (printNum % 5 == 0)
                {
                    Console.WriteLine();
                }
            }

        }
    }
}

