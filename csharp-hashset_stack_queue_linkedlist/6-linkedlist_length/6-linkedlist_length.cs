using System;
using System.Collections.Generic;

public class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        // Check if the LinkedList is null
        if (myLList == null)
        {
            return 0; // or throw an exception, based on your use case
        }

        int count = 0;
        LinkedListNode<int> current = myLList.First;

        while (current != null)
        {
            count++;
            current = current.Next;
        }

        return count;
    }
}
