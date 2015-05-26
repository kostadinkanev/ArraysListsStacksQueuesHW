using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;

class SortTwo
{
    static void Main()
    {
        string n = Console.ReadLine();
        string[] help = n.Split(' ');
        List<double> numbers = new List<double>();
        List<double> sortNum = new List<double>();
        for (int i = 0; i < help.Length; i++)
        {
            numbers.Add(double.Parse(help[i]));
        }

        int p = numbers.Count ;

        for (int i = 0; i < p; i++)
        {
            

            sortNum.Add(numbers.Min());
            numbers.Remove(numbers.Min());
        }

        Console.WriteLine();
        Console.WriteLine();

        for (int i = 0; i < sortNum.Count; i++)
        {
            Console.Write("{0} ", sortNum[i]);
        }
    }
}

