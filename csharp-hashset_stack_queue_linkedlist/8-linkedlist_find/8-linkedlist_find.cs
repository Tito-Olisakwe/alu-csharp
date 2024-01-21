using System;
using System.Collections.Generic;

public class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        // Check if the LinkedList is null
        if (myLList == null)
        {
            return -1;
        }

        int index = 0;
        foreach (int item in myLList)
        {
            if (item == value)
            {
                return index;
            }
            index++;
        }

        // Return -1 if the value is not found
        return -1;
    }
}
