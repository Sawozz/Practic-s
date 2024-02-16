using System;

class Function4
{
    static void Main()
    {
        int[] massive = new int[5];
        Console.WriteLine("Введите пять чисел");
        for (int i = 0; i < 5; i++)
        {
            massive[i] = Convert.ToInt32(Console.ReadLine());
        }

        int Cislo(int[] arr)
        {
            int maxValue = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > maxValue)
                {
                    maxValue = arr[i];
                }
            }

            return maxValue;
        }

        Console.WriteLine("Большее: " + Cislo(massive));
    }
}