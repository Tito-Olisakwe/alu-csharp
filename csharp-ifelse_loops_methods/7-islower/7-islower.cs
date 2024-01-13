using System;

class Character
{
    public static bool IsLower(char c)
    {
        return c >= 'a' && c <= 'z';
    }
}

class Program
{
    static void Main(string[] args)
    {
        char[] letters = { 'a', 'A', 'Q', 'h', '9', 'B', 'g' };
        int i;

        for (i = 0; i < letters.Length; i++)
        {
            if (Character.IsLower(letters[i]))
            {
                Console.WriteLine("{0} is lowercase", letters[i]);
            }
            else if (Character.IsUpper(letters[i]))
            {
                Console.WriteLine("{0} is uppercase", letters[i]);
            }
            else
            {
                Console.WriteLine("{0} is neither lowercase nor uppercase", letters[i]);
            }
        }
    }

    public static bool IsUpper(char c)
    {
        return c >= 'A' && c <= 'Z';
    }
}
