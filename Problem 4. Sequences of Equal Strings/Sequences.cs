using System;
using System.Collections.Generic;

class Sequences
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] word = input.Split(' ');
        List<string> words = new List<string>();
        for (int i = 0; i < word.Length; i++)
        {
            words.Add(word[i]);
        }


        Console.Write("{0} ",words[0]);
        for (int i = 0; i < words.Count - 1; i++)
        {
            if (words[i] == words[i + 1])
            {
                Console.Write("{0} ", words[i]);

            }
            else
            {
                Console.WriteLine();
                Console.Write("{0} ", words[i + 1]);

            }
        }
        Console.WriteLine();
    }

}

