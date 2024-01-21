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

class Program
{
    static void Main(string[] args)
    {
        LinkedList<int> myLList = new LinkedList<int>();
        LinkedListNode<int> current;

        myLList.AddLast(1);
        myLList.AddLast(4);
        myLList.AddLast(9);
        myLList.AddLast(16);
        myLList.AddLast(25);
        myLList.AddLast(36);
        myLList.AddLast(49);

        current = myLList.First;
        while (current != null)
        {
            Console.WriteLine(current.Value);
            current = current.Next;
        }

        Console.WriteLine("-------------------");
        LList.Delete(myLList, 5);

        current = myLList.First;
        while (current != null)
        {
            Console.WriteLine(current.Value);
            current = current.Next;
        }
    }
}
