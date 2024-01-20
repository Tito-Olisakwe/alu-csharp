using System;
using System.Collections.Generic;

public class Dictionary
{
    public static Dictionary<string, string> DeleteKeyValue(Dictionary<string, string> myDict, string key)
    {
        // Create a new dictionary to hold the updated values
        Dictionary<string, string> updatedDict = new Dictionary<string, string>(myDict);

        // Remove the key if it exists
        updatedDict.Remove(key);

        return updatedDict;
    }
}
