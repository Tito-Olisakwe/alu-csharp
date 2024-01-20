using System;
using System.Collections.Generic;

public class Dictionary
{
    public static Dictionary<string, string> DeleteKeyValue(Dictionary<string, string> myDict, string key)
    {
        // Check if the dictionary contains the key and remove it
        if (myDict.ContainsKey(key))
        {
            myDict.Remove(key);
        }

        // Return the original dictionary
        return myDict;
    }
}
