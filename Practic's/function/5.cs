using System;

class Function5
{
    static void Main()
    {
        Console.WriteLine("Введите число");

        long num = Convert.ToInt64(Console.ReadLine());

        long fac(long number)
        {
            long result = 1;
            for (long i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }

        Console.WriteLine("Факториал: " + fac(num));
    }
}