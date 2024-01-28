using System;

class _7
{
    static void Main()
    {
        for (int i = 1; i <= 9; i++)
        {
            for (int j = 1; j <= 9; j++)
            {
                int result = i * j;
                Console.Write($"{i} * {j} = {result}");
                if (j == 9)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(", ");
                }
            }
        }
    }
}