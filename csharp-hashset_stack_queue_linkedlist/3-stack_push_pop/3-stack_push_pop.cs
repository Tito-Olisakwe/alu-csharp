using System;
using System.Collections.Generic;

public class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        // Print the number of items in the stack
        Console.WriteLine("Number of items: " + aStack.Count);

        // Print the top item of the stack
        if (aStack.Count > 0)
        {
            Console.WriteLine("Top item: " + aStack.Peek());
        }
        else
        {
            Console.WriteLine("Stack is empty");
        }

        // Print whether the stack contains 'search'
        bool containsSearch = aStack.Contains(search);
        Console.WriteLine("Stack contains \"" + search + "\": " + containsSearch);

        // If the stack contains 'search', pop items until 'search' is found
        if (containsSearch)
        {
            string item;
            do
            {
                item = aStack.Pop();
            }
            while (item != search && aStack.Count > 0);
        }

        // Add the new item to the stack
        aStack.Push(newItem);

        return aStack;
    }
}
