using System;
using System.Collections.Generic;

public class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> linkedList = new LinkedList<int>();

        // If size is negative, return an empty list
        if (size < 0)
        {
            return linkedList;
        }

        // Populate and print the list
        for (int i = 0; i < size; i++)
        {
            linkedList.AddLast(i);
            Console.WriteLine(i);
        }

        return linkedList;
    }
}
