using System;

public class Array
{
    public static void Reverse(int[] array)
    {
        // No null check. Directly accessing array.Length will trigger a warning if array is null
        if (array.Length == 0)
        {
            Console.WriteLine();
            return;
        }

        for (int i = array.Length - 1; i >= 0; i--)
        {
            Console.Write(array[i] + (i > 0 ? " " : "\n"));
        }
    }
}
