using System;

public class Array
{
    public static void Reverse(int[] array)
    {
        // Handle null and empty arrays by returning early without printing anything
        if (array == null || array.Length == 0)
        {
            return;
        }

        // Process and print non-empty arrays
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Console.Write(array[i] + (i > 0 ? " " : "\n"));
        }
    }
}
