using System;

class Function7
{
    static void Main()
    {
        Console.WriteLine("Введите первый массив");

        int[] mass1 = new int[5];

        for (int i = 0; i < 5; i++)
        {
            mass1[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Введите второй массив");

        int[] mass2 = new int[5];

        for (int i = 0; i < 5; i++)
        {
            mass2[i] = Convert.ToInt32(Console.ReadLine());
        }

        string func(int[] x, int[] y)
        {
            return string.Join(", ", x.Concat(y).ToArray());
        }

        Console.WriteLine("Полученный массив: " + func(mass1, mass2));
    }
}