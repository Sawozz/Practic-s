class _11
{
    static void Main()
    {
        Console.WriteLine("массив состоит из:" +
             "1, 2, 3, 4, 5, 6, 7, 8, 9, 10");
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int sum = 0;
        int average = 0;
 
        foreach (int num in arr)
        {
            sum += num;
        }

        average = sum / arr.Length;

        Console.WriteLine("Среднее арифметическое элементов массива: " + average);
    }
}