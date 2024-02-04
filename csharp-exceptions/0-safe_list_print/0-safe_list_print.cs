using System;
using System.Collections.Generic;

public class List
{
    // Method to safely print elements of the list
    public static int SafePrint(List<int> myList, int n)
    {
        int printedCount = 0;
        try
        {
            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(myList[i]);
                printedCount++;
            }
        }
        catch (ArgumentOutOfRangeException)
        {
            // If n exceeds the list size, catch the exception
            // No further action needed as we just stop printing
        }
        return printedCount;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<int> myList = new List<int>() {1, 2, 3, 4, 5};
        int count;

        // Print all elements in the list
        count = List.SafePrint(myList, myList.Count);
        Console.WriteLine("Number of integers printed: " + count);
        Console.WriteLine();

        // Print fewer elements than the list contains
        count = List.SafePrint(myList, myList.Count - 2);
        Console.WriteLine("Number of integers printed: " + count);
        Console.WriteLine();

        // Attempt to print more elements than the list contains
        count = List.SafePrint(myList, myList.Count + 2);
        Console.WriteLine("Number of integers printed: " + count);
    }
}
