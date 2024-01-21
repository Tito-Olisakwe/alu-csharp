using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        // Check if the list is null or empty
        if (myLList == null || myLList.Count == 0)
        {
            // If the list is null or empty, add the item and return the new node
            return myLList?.AddFirst(n);
        }

        LinkedListNode<int> current = myLList.First;

        while (current != null)
        {
            if (current.Value >= n)
            {
                // Add before the current node and return the newly added node
                return myLList.AddBefore(current, n);
            }
            current = current.Next;
        }

        // If we reach here, it means the new value should be added at the end of the list
        return myLList.AddLast(n);
    }
}
