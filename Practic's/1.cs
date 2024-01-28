using System;

namespace NumberComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два числа");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine($"Первое число ({a}) больше второго ({b})");
            }
            else if (a < b)
            {
                Console.WriteLine($"Первое число ({a}) меньше второго ({b})");

            }

            else
            {
                Console.WriteLine("Числа равны");
            }
        }
    }
}