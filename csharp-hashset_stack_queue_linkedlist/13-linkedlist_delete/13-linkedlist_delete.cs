using System;
using System.Collections.Generic;

public class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        if (myLList == null || index < 0)
        {
            return; // Return if the list is null or index is negative
        }

        // Handling deletion at the start of the list
        if (index == 0)
        {
            if (myLList.First != null)
            {
                myLList.RemoveFirst();
            }
            return;
        }

        LinkedListNode<int> current = myLList.First;
        int currentIndex = 0;

        // Traverse the list to find the node at the given index
        while (current != null && currentIndex < index)
        {
            current = current.Next;
            currentIndex++;
        }

        // If the node exists, remove it
        if (current != null)
        {
            myLList.Remove(current);
        }
    }
}
