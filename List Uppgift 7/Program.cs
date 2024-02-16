using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string[] array1 = { "a", "b", "b", "c", "hej", "hej", "Programmering" };
        string[] array2 = { "hej", "a", "a", "b", "Programmering", "Drake" };

        string[] båda = FinnsIBåda(array1, array2);

        foreach (string item in båda)
        {
            Console.WriteLine(item);
        }
    }

    static string[] FinnsIBåda(string[] array1, string[] array2)
    {
        Dictionary<string, int> frekvens = new Dictionary<string, int>();

        
        foreach (string ord1 in array1)
        {
            if (frekvens.ContainsKey(ord1))
            {
                frekvens[ord1]++;
            }
            else
            {
                frekvens[ord1] = 1;
            }
        }

       
        foreach (string ord2 in array2)
        {
            if (frekvens.ContainsKey(ord2))
            {
                frekvens[ord2]++;
            }
            else
            {
                frekvens[ord2] = 1;
            }
        }

      
        List<string> flerfaldigaOrd = new List<string>();

        foreach (var item in frekvens)
        {
            if (item.Value > 1)
            {
                flerfaldigaOrd.Add(item.Key);
            }
        }

        return flerfaldigaOrd.ToArray();
    }
}
