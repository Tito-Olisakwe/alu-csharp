using System;

public class Array
{
    public static void Reverse(int[] array)
    {
        // Removed the null check to allow the compiler to trigger the warning
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
