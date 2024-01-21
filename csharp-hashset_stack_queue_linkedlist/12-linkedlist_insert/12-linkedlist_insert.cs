using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        // Check if the list is null
        if (myLList == null)
        {
            myLList = new LinkedList<int>();
            myLList.AddFirst(n);
            return myLList.First;
        }

        // If the list is empty, add the item as the first node
        if (myLList.Count == 0)
        {
            return myLList.AddFirst(n);
        }

        LinkedListNode<int> current = myLList.First;

        // Traverse the list to find the correct position for insertion
        while (current != null)
        {
            if (current.Value >= n)
            {
                // Add before the current node and return the head of the list
                myLList.AddBefore(current, n);
                return myLList.First;
            }
            current = current.Next;
        }

        // If the new value is greater than all elements in the list, add it to the end
        myLList.AddLast(n);
        return myLList.First;
    }
}
