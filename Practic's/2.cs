namespace Practic_s
{
    class _2
    {
        static void JOb(string[] args)
        {
            Console.WriteLine("Введите число");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a <=5 && a>= 10) {
                Console.WriteLine("Число больше 5 и меньше 10");
            }
            else
            {
                Console.WriteLine("Неизвестное число");
            }
        }


    }
}
