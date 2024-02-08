using System;

class Function2
{
    static void Main()
    {
        Console.WriteLine("Радиус");
        int r = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Площадь");
        void square()
        {
            double s = 0;
            s = 3.14 * (r * r);
            
            Console.WriteLine($"Pi*R^2 = {s}");
        }
        square();
    }
}