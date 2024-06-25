using System;


/// <summary>
/// queue of type defined
/// </summary>
/// <typeparam name="T"></typeparam>
public class Queue<T>  {


/// <summary>
/// Node class struct
/// </summary>
    public class Node{

        public T? Value;
        public Node? Next;

        public Node(T value){
            Value = value;
            Next = null;
        }
    }

// first element of queue
    protected Node? head;
    // last element of the queue
    protected Node? tail;
    // number of items in queue
    int count;

// constructor assignment
    public Queue()
    {
        head = null;
        tail = null;
        count = 0;
    }


/// <summary>
/// adding elements at queue end
/// </summary>
/// <param name="value"></param>
    public void Enqueue(T? value){

        Node newNode = new Node(value!);
    
        if(head == null){
            head = newNode;
            tail = newNode;
        }else{
            tail!.Next = newNode;
            tail = newNode;
        }
         count++;
    }

    
    

/// <summary>
/// returns type of generic
/// </summary>
/// <returns></returns>
    public Type CheckType(){
        return typeof(T);
    }

/// <summary>
/// returns the number of items
/// </summary>
/// <returns></returns>
    public int Count(){
        return count;
    }
    
}

