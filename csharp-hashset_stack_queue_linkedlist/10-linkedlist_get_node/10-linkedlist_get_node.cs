using System;
using System.Collections.Generic;

public class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        if (myLList == null || n < 0)
        {
            return 0; // Return 0 for null list or negative index
        }

        LinkedListNode<int> current = myLList.First;
        int index = 0;

        // Traverse the list until you find the nth node or reach the end of the list
        while (current != null && index < n)
        {
            current = current.Next;
            index++;
        }

        // Check if the nth node was found
        if (current != null && index == n)
        {
            return current.Value;
        }

        return 0; // Return 0 if the nth node does not exist
    }
}
