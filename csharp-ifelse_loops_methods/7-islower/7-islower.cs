using System;

class Program
{
    static void Main(string[] args)
    {
        char[] letters = { 'a', 'A', 'Q', 'h', '9', 'B', 'g' };

        for (int i = 0; i < letters.Length; i++)
        {
            if (letters[i] >= 'a' && letters[i] <= 'z')
            {
                Console.WriteLine("{0} is lowercase", letters[i]);
            }
            else if (letters[i] >= 'A' && letters[i] <= 'Z')
            {
                Console.WriteLine("{0} is uppercase", letters[i]);
            }
            else
            {
                Console.WriteLine("{0} is neither lowercase nor uppercase", letters[i]);
            }
        }
    }
}
