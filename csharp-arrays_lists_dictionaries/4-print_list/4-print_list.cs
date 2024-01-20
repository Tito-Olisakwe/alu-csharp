using System;
using System.Collections.Generic;

public class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        if (size == 0)
        {
            Console.WriteLine(); // Print a newline for a size of 0
            return new List<int>();
        }

        List<int> newList = new List<int>();

        for (int i = 0; i < size; i++)
        {
            newList.Add(i);
            Console.Write(i + (i < size - 1 ? " " : "\n"));
        }

        return newList;
    }
}
