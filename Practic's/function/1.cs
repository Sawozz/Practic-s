using System;

class Function
{
    static void Main()
    {
        Console.WriteLine("Числа");
        int a = Convert.ToInt32 (Console.ReadLine());
        int b = Convert.ToInt32 (Console.ReadLine());
        void Summ()
        {
            int s = 0;
            s = a + b;
            Console.WriteLine($"{a} + {b} = {s}");
        }

        Summ();
    }
}