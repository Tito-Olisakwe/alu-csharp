using System;
using System.Collections.Generic;

public class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    // Return 0 for a null list or a negative index
        if (myLList == null || n < 0)
        {
            return 0;
        }

        // Initialize a node to start from the beginning of the list
        LinkedListNode<int> current = myLList.First;
        int index = 0;

        // Traverse the list until the nth node is reached or the end of the list
        while (current != null && index < n)
        {
            current = current.Next;
            index++;
        }

        // Check if the nth node is found and return its value
        if (current != null && index == n)
        {
            return current.Value;
        }

        // Return 0 if the nth node does not exist
        return 0;
    }

    static void Main()
    {
        LinkedList<int> myLinkedList = new LinkedList<int>();

        // Adding some elements to the LinkedList
        myLinkedList.AddLast(91);
        myLinkedList.AddLast(-22);
        myLinkedList.AddLast(13);
        myLinkedList.AddLast(14);
        myLinkedList.AddLast(-54);
        myLinkedList.AddLast(66);
        myLinkedList.AddLast(37);
        myLinkedList.AddLast(-8);

        // Trying to get the value of node at different positions
        Console.WriteLine("Value at index 5: " + GetNode(myLinkedList, 5));
        Console.WriteLine("Value at index 0: " + GetNode(myLinkedList, 0));
        Console.WriteLine("Value at index 10 (non-existent): " + GetNode(myLinkedList, 10));
    }
}
