using System;
using System.Collections.Generic;

public class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        if (index < 0 || index >= myList.Count)
        {
            Console.WriteLine("Index is out of range");
            return myList;
        }

        for (int i = index; i < myList.Count - 1; i++)
        {
            myList[i] = myList[i + 1];
        }

        myList.RemoveAt(myList.Count - 1); // Removing the last element

        return myList;
    }
}
