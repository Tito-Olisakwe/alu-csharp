using System;

public class Int
{
    public static void divide(int a, int b)
    {
        int result = 0;
        
        try
        {
            result = a / b;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
            // Explicitly setting result to 0 here to handle cases where division by zero occurs.
            result = 0;
        }
        finally
        {
            Console.WriteLine($"{a} / {b} = {result}");
        }
    }
}
