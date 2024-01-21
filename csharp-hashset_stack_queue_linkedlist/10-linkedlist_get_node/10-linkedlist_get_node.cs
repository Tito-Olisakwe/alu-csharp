using System;
using System.Collections.Generic;

public class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
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

}