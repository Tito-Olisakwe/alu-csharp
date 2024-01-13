using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 100; i++)
        {
            // Format each number as two digits
            Console.Write($"{i:D2}");

            // Add a comma and space except after the last number
            if (i < 99)
            {
                Console.Write(", ");
            }
        }
        // Add a new line after the loop
        Console.WriteLine();
    }
}
