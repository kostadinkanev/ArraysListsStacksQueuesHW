using System;


class SortArrayOfNumbers
{
    static void Main()
    {
        string numbs = Console.ReadLine();
        string[] numbers = numbs.Split(' ');
        while (true)
        {
            bool hasSwapped = false;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (int.Parse(numbers[i]) > int.Parse(numbers[i + 1]))
                {
                    string oldValue = numbers[i];
                    numbers[i] = numbers[i + 1];
                    numbers[i + 1] = oldValue;
                    hasSwapped = true;
                }
            }
            if (hasSwapped == false)
            {
                break;
            }
        }
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();
    }
}

