using System;

class Function6
{
    static void Main()
    {
        Console.WriteLine("Введите слова");

        string words = Console.ReadLine();

        bool check(string i)
        {
            string reverse = new string(i.ToCharArray().Reverse().ToArray());
            if (i.Equals(reverse))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        Console.WriteLine("Вывод: " + check(words));
    }
}