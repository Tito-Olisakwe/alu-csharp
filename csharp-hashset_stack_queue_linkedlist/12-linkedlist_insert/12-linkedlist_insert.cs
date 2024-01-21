using System;
using System.Collections.Generic;

public class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        // Handle the case where the list is null
        if (myLList == null)
        {
            myLList = new LinkedList<int>();
        }

        LinkedListNode<int> current = myLList.First;

        // If the list is empty or the new value is smaller than the first value, add to the front
        if (current == null || current.Value >= n)
        {
            return myLList.AddFirst(n);
        }

        // Iterate through the list to find the correct position
        while (current.Next != null && current.Next.Value < n)
        {
            current = current.Next;
        }

        // Insert the new node
        return myLList.AddAfter(current, n);
    }
}
