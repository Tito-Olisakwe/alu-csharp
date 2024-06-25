#nullable enable

using System;

/// <summary>
/// Represents a queue of a specified type.
/// </summary>
/// <typeparam name="T">The type of elements in the queue.</typeparam>
public class Queue<T>
{
    /// <summary>
    /// Represents a node in the queue.
    /// </summary>
    public class Node
    {
        /// <summary>
        /// The value stored in the node.
        /// </summary>
        public T? Value;

        /// <summary>
        /// The next node in the queue.
        /// </summary>
        public Node? Next;

        /// <summary>
        /// Initializes a new instance of the <see cref="Node"/> class.
        /// </summary>
        /// <param name="value">The value to store in the node.</param>
        public Node(T value)
        {
            Value = value;
            Next = null;
        }
    }

    /// <summary>
    /// The first node in the queue.
    /// </summary>
    protected Node? head;

    /// <summary>
    /// The last node in the queue.
    /// </summary>
    protected Node? tail;

    /// <summary>
    /// The number of items in the queue.
    /// </summary>
    int count;

    /// <summary>
    /// Initializes a new instance of the <see cref="Queue{T}"/> class.
    /// </summary>
    public Queue()
    {
        head = null;
        tail = null;
        count = 0;
    }

    /// <summary>
    /// Adds an element to the end of the queue.
    /// </summary>
    /// <param name="value">The value to add to the queue.</param>
    public void Enqueue(T value)
    {
        Node newNode = new Node(value);
        
        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail!.Next = newNode;
            tail = newNode;
        }
        count++;
    }

    /// <summary>
    /// Removes and returns the first element from the queue.
    /// </summary>
    /// <returns>The value of the removed element.</returns>
    public T? Dequeue()
    {
        T? currentValue;

        if (count == 0)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        else
        {
            count--;
            currentValue = head!.Value;
            head = head.Next;
        }

        return currentValue;
    }

    /// <summary>
    /// Returns the first element without removing it from the queue.
    /// </summary>
    /// <returns>The value of the first element in the queue.</returns>
    public T? Peek()
    {
        if (count == 0)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }

        return head!.Value;
    }

    /// <summary>
    /// Displays all elements in the queue.
    /// </summary>
    public void Print()
    {
        if (count == 0)
        {
            Console.WriteLine("Queue is empty");
            return;
        }

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(head!.Value);
            head = head.Next;
        }
    }

    /// <summary>
    /// Returns the type of the elements in the queue.
    /// </summary>
    /// <returns>The type of the elements in the queue.</returns>
    public Type CheckType()
    {
        return typeof(T);
    }

    /// <summary>
    /// Returns the number of items in the queue.
    /// </summary>
    /// <returns>The number of items in the queue.</returns>
    public int Count()
    {
        return count;
    }
}
