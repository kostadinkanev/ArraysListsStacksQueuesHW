using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string inPut = Console.ReadLine();
        string[] nums = inPut.Split(' ');
        List<double> doub = new List<double>();
        List<double> full = new List<double>();
        double minf = double.MaxValue;
        double maxf = double.MinValue;
        double min = Double.MaxValue;
        double max = Double.MinValue;
        double sumf = 0;
        double sum = 0;
        double avr; 
        for (int i = 0; i < nums.Length; i++)
        {
            if ((double.Parse(nums[i]) * 10 ) % 10  == 0)
            {
                full.Add(double.Parse(nums[i]) );
            }
            else
            {
                doub.Add(double.Parse(nums[i]));
            }
        }

        for (int i = 0; i < full.Count; i++)
        {
            if (full[i] <= minf)
            {
                minf = full[i];
            }
            if (full[i] >= maxf)
            {
                maxf = full[i];
            }
            sumf += full[i];
        }

        for (int i = 0; i < doub.Count; i++)
        {
            if (doub[i] <= min)
            {
                min = doub[i];
            }
            if (doub[i] >= max)
            {
                max = doub[i];
            }
            sum += doub[i];
        }

        avr = sumf/full.Count;

        Console.Write("[");
        foreach (var g in doub)
        {
            Console.Write("{0} ", g);
        }
        Console.Write("]");
        Console.WriteLine(" -> min: {0:F2}, max: {1:F2}, sum: {2:F2}, avg: {3:F2}", min, max, sum, (sum / doub.Count));
        
        Console.Write("[");
        foreach (var s in full)
        {
            Console.Write("{0} ", s);
        }
        Console.Write("]");
        Console.WriteLine(" -> min: {0:#}, max: {1:#}, sum: {2:#}, avg: {3:F2}", minf, maxf, sumf, avr);
        
        
    
    }
}

