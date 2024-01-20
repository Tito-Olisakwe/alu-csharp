using System;

public class Array
{
    public static void Reverse(int[] array)
    {
        // No null checks; proceed directly to processing the array
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Console.Write(array[i] + (i > 0 ? " " : "\n"));
        }
    }
}
