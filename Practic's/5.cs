using System;

    class _5
    {
        public static void Main(string[] args)
        {
            string operation;
            int operationNumber;

            Console.WriteLine("Введите номер операции (1. Сложение, 2. Вычитание, 3. Умножение):");
            operationNumber = Convert.ToInt16(Console.ReadLine());

            switch (operationNumber)
            {
                case 1:
                    operation = "Сложение";
                    break;
                case 2:
                    operation = "Вычитание";
                    break;
                case 3:
                    operation = "Умножение";
                    break;
                default:
                    Console.WriteLine("Некорректный ввод!");
                    return;
            }
            Console.WriteLine($"Вы выбрали операцию: {operation}");
        }
    }