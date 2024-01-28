namespace Practic_s
{
    class _3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a == 5 || a == 10)
            {
                Console.WriteLine("Число либо 5, лмбо 10");
            }
            else
            {
                Console.WriteLine("Неизвестное число");
            }
        }


    }
}