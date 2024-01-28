using System;

public class _6
{

    public static void Main()
    {
        Console.Write("Введите начальную сумму вклада:");
        decimal initialSum = Convert.ToDecimal(Console.ReadLine()); 

        Console.Write("Введите количество месяцев:");
        int monthsCount = Convert.ToInt32(Console.ReadLine());

        decimal P = 0.07M ;

        for (int i = 1; i <= monthsCount; i++)
        {
            initialSum += initialSum * P;
        }

        Console.WriteLine("Конечная сумма вклада с учетом процентов: " + initialSum);
    }
}