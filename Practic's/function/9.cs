using System;

class Function9
{
    static void Main()
    {
        Console.WriteLine("Напишите");

        string strng = Console.ReadLine();

        string x(string i)
        {
            return new string(i.ToCharArray().Reverse().ToArray());
        }

        Console.WriteLine("Вывод: " + x(strng));
    }
}