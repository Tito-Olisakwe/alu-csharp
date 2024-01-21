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

        Console.WriteLine("------------------");
        LList.Insert(myLList, 21);

        current = myLList.First;
        while (current != null)
        {
            Console.WriteLine(current.Value);
            current = current.Next;
        }
    }
}
