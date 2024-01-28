using System;
using System.Linq;



    class _10
    {
        static void Main(string[] args)
        {
            
            string[] strings = { "Яблоко", "Банан", "Вишня", "Апельсин", "Манго", "Киви", "Гранат", "Лимон" };

            
            Console.WriteLine("Введите фрукт для поиска:");
            string input = Console.ReadLine();

            if (strings.Contains(input))
            {
                Console.WriteLine("Фрукт найден!");
            }
            else
            {
                Console.WriteLine("Фрукт не найден!");
            }

            Console.ReadKey();
        }
    }
