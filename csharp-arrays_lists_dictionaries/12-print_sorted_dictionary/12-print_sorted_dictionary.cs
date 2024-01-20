using System;
using System.Collections.Generic;
using System.Linq;

public class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        // Extract keys and sort them
        var sortedKeys = myDict.Keys.OrderBy(key => key).ToList();

        // Iterate over the sorted keys and print the key-value pairs
        foreach (var key in sortedKeys)
        {
            Console.WriteLine("{0}: {1}", key, myDict[key]);
        }
    }
}
