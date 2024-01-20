4. Queue it up
mandatory
Given a Queue<string>, write a method that does the following:

Class: MyQueue
Prototype: public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
Print the number of items in aQueue
Format: Number of items: <number>
Print the item at the top of aQueue without removing it
Format: First item: <item>
If aQueue is empty, print Queue is empty
Add a new given item newItem to aQueue
Print if aQueue contains a given item search
Format: Queue contains <search>: <True / False>
If aQueue contains the given item search, remove all items up to and including search; otherwise, leave aQueue as is
You can use .Dequeue() only once
Return aQueue
carrie@ubuntu:~//4-queue_enqueue_dequeue$ cat 4-main.cs
using System;
using System.Collections.Generic;

class Program
{
    // Main - entry point
    static void Main(string[] args)
    {
        Queue<string> aQueue = new Queue<string>();

        aQueue.Enqueue("C");
        aQueue.Enqueue("HTML");
        aQueue.Enqueue("Javascript");
        aQueue.Enqueue("Python");
        aQueue.Enqueue("React");
        aQueue.Enqueue("Ruby");

        foreach (string item in aQueue)
            Console.WriteLine(item);

        Console.WriteLine("------");

        MyQueue.Info(aQueue, "C#", "Javascript");

        Console.WriteLine("------");

        foreach (string item in aQueue)
            Console.WriteLine(item);
    }
}
carrie@ubuntu:~//4-queue_enqueue_dequeue$
carrie@ubuntu:~//4-queue_enqueue_dequeue$ ls
4-main.cs  4-queue_enqueue_dequeue.cs  4-queue_enqueue_dequeue.csproj  bin  obj
carrie@ubuntu:~//4-queue_enqueue_dequeue$ dotnet run
C
HTML
Javascript
Python
React
Ruby
------
Number of items: 6
First item: C
Queue contains "Javascript": True
------
Python
React
Ruby
C#
carrie@ubuntu:~//4-queue_enqueue_dequeue$ 