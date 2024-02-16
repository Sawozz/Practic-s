using System;

class Function10
{
    static void Main()
    {
        Console.WriteLine("Введите введите двумерный массив числел");

        int[,] mass1 = new int[3, 3];

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("новая строка");
            for (int j = 0; j < 3; j++)
            {
                mass1[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        int sum(int[,] z)
        {
            {
                int sum = 0;
                foreach (int num in z)
                {
                    sum += num;
                }
                return sum;
            }
        }

        Console.WriteLine("Сумма: " + sum(mass1));
    }
}
