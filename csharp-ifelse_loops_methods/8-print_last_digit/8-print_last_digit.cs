using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        int lastDigit = Math.Abs(number % 10); // Use Math.Abs to handle negative numbers
        Console.Write(lastDigit); // Print the last digit without a new line
        return lastDigit;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int r;

        Number.PrintLastDigit(98); // Prints 8
        Number.PrintLastDigit(0);  // Prints 0
        r = Number.PrintLastDigit(-1024); // Prints 4 and assigns it to r
        Console.WriteLine(r); // Prints 4 with a new line
    }
}
