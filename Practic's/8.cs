using System;

class _8
{
    public static void Main(string[] args)
    {
        bool validInput = false;

        while (!validInput)
        {

            try
            {
                Console.WriteLine("Введите два числа:");
                double num1 = Convert.ToDouble(Console.ReadLine());
                double num2 = Convert.ToDouble(Console.ReadLine());

                validInput = (num1 >= 0 && num1 <= 10 && num2 >= 0 && num2 <= 10);

                if (validInput)
                {
                    double result = num1 * num2;
                    Console.WriteLine($"Произведение чисел: {num1} и {num2} равно: {result}");

                }
                else
                {
                    Console.WriteLine("Введенные числа недопустимые. Повторите попытку.");
                }


            }
            catch (FormatException)
            {

                Console.WriteLine("Вы ввели некорректное значение. Введите число заново.");
            }

        }
    }
}