using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите сумму вклада: ");
        double amount = Convert.ToSingle(Console.ReadLine());
        if (amount < 100)
        {
            amount += (amount * 5) / 100;
        }
        else if (amount >= 100 && amount <= 200)
        {
            amount += (amount * 7) / 100;
        }
        else
        {
            amount += (amount * 10) / 100;
        }

        Console.WriteLine("Сумма вклада с процентами: " + amount);
    }
}