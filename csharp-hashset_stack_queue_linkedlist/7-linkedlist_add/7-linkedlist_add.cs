using System;
using System.Collections.Generic;

public class LList
{
    public static LinkedListNode<int> Add(LinkedList<int> myLList, int n)
    {
        // Creating a new node with the value 'n'
        LinkedListNode<int> newNode = new LinkedListNode<int>(n);

        // Adding the new node to the beginning of the linked list
        myLList.AddFirst(newNode);

        // Returning the newly added node
        return newNode;
    }
}
