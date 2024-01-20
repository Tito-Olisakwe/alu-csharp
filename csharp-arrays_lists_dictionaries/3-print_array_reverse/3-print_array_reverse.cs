using System;

public class Array
{
    public static void Reverse(int[] array)
    {
        // Check if the array is null
        if (array == null)
        {
            // Handle the null array case (seems like you need to print nothing)
            return;
        }

        // Check if the array is empty
        if (array.Length == 0)
        {
            // Handle the empty array case (print nothing)
            return;
        }

        // Process the non-empty array
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Console.Write(array[i] + (i > 0 ? " " : ""));
        }

        // Print a newline if the array was not empty
        Console.WriteLine();
    }
}
