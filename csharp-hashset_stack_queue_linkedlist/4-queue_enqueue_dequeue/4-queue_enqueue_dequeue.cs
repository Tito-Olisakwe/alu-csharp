using System;
using System.Collections.Generic;

public class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        // Print the number of items in the queue
        Console.WriteLine("Number of items: " + aQueue.Count);

        // Print the top item if the queue is not empty
        if (aQueue.Count > 0)
        {
            Console.WriteLine("First item: " + aQueue.Peek());
        }
        else
        {
            Console.WriteLine("Queue is empty");
        }

        // Add the new item
        aQueue.Enqueue(newItem);

        // Check if the queue contains the search item
        bool containsItem = aQueue.Contains(search);
        Console.WriteLine($"Queue contains \"{search}\": {containsItem}");

        // Remove items up to and including the search item, if it exists
        if (containsItem)
        {
            string currentItem;
            do
            {
                currentItem = aQueue.Dequeue();
            } while (currentItem != search && aQueue.Count > 0);
        }

        return aQueue;
    }
}
