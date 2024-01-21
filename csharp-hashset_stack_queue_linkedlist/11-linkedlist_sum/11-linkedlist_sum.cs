using System;
using System.Collections.Generic;

public class LList
{
    public static int Sum(LinkedList<int> myLList)
    {
        int sum = 0;

        if (myLList == null)
        {
            return sum;
        }

        foreach (int value in myLList)
        {
            sum += value;
        }

        return sum;
    }
}

class Program
{
    static void Main(string[] args)
    {
        LinkedList<int> myLList = new LinkedList<int>();

        myLList.AddLast(21);
        myLList.AddLast(9);
        myLList.AddLast(-8);
        myLList.AddLast(54);
        myLList.AddLast(23);
        myLList.AddLast(-6);
        myLList.AddLast(5);

        Console.WriteLine(LList.Sum(myLList)); // Expected output: 98
    }
}
