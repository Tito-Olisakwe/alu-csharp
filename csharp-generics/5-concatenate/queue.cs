#nullable enable

using System;

/// <summary>
/// Queue of type defined
/// </summary>
/// <typeparam name="T">The type of elements in the queue</typeparam>
public class Queue<T>
{
    /// <summary>
    /// Node class struct
    /// </summary>
    public class Node
    {
        /// <summary>
        /// Gets or sets the value of the node
        /// </summary>
        public T? Value;

        /// <summary>
        /// Gets or sets the next node in the queue
        /// </summary>
        public Node? Next;

        /// <summary>
        /// Initializes a new instance of the <see cref="Node"/> class.
        /// </summary>
        /// <param name="value">The value of the node</param>
        public Node(T value)
        {
            Value = value;
            Next = null;
        }
    }

    // First element of queue
    protected Node? head;

    // Last element of the queue
    protected Node? tail;

    // Number of items in queue
    int count;

    // Constructor assignment
    public Queue()
    {
        head = null;
        tail = null;
        count = 0;
    }

    /// <summary>
    /// Adds an element at the end of the queue
    /// </summary>
    /// <param name="value">The value to be added to the queue</param>
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
    /// Removes and returns the element at the beginning of the queue
    /// </summary>
    /// <returns>The value of the removed element</returns>
    public T? Dequeue()
    {
        if (count == 0)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }

        T? currentValue = head!.Value;
        head = head!.Next;
        count--;

        if (count == 0)
        {
            tail = null;
        }

        return currentValue;
    }

    /// <summary>
    /// Returns the first element without removing it from the queue
    /// </summary>
    /// <returns>The value of the first element</returns>
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
    /// Displays all elements in the queue
    /// </summary>
    public void Print()
    {
        if (count == 0)
        {
            Console.WriteLine("Queue is empty");
            return;
        }

        Node? current = head;
        while (current != null)
        {
            Console.WriteLine(current.Value);
            current = current.Next;
        }
    }

    /// <summary>
    /// Combines strings or chars in the queue into a single string
    /// </summary>
    /// <returns>A concatenated string of all elements in the queue</returns>
    public string? Concatenate()
    {
        if (count == 0)
        {
            Console.WriteLine("Queue is empty");
            return null;
        }

        if (CheckType() != typeof(string) && CheckType() != typeof(char))
        {
            Console.WriteLine("Concatenate() is for a queue of Strings or Chars");
            return null;
        }

        string outputValue = "";

        Node? current = head;
        while (current != null)
        {
            outputValue += current.Value;
            if (CheckType() == typeof(string))
            {
                outputValue += " ";
            }
            current = current.Next;
        }

        return outputValue.Trim();
    }

    /// <summary>
    /// Returns the type of the generic
    /// </summary>
    /// <returns>The type of the elements in the queue</returns>
    public Type CheckType()
    {
        return typeof(T);
    }

    /// <summary>
    /// Returns the number of items in the queue
    /// </summary>
    /// <returns>The number of elements in the queue</returns>
    public int Count()
    {
        return count;
    }
}

/// <summary>
/// Program class with the Main method
/// </summary>
public class Program
{
    /// <summary>
    /// The entry point of the program
    /// </summary>
    /// <param name="args">The command-line arguments</param>
    public static void Main(string[] args)
    {
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("Hello");
        queue.Enqueue("Holberton");
        queue.Enqueue("School");

        Console.WriteLine(queue.Concatenate());
    }
}
