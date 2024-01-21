using System;
using System.Collections.Generic;

public class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        // Check if the LinkedList is empty
        if (myLList == null || myLList.First == null)
        {
            return 0;
        }

        // Get the value of the first node
        int value = myLList.First.Value;

        // Remove the first node
        myLList.RemoveFirst();

        // Return the value of the removed node
        return value;
    }
}
