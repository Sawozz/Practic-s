using System;

class Function8
{
    static void Main()
    {
        Console.WriteLine("Введите число");

        int num = Convert.ToInt32(Console.ReadLine());

        bool check(int a)
        {
            if (a <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(a); i++)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        Console.WriteLine("Вывод: " + check(num));
    }
}