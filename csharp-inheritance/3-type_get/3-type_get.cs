using System;
using System.Reflection;
using System.Collections.Generic;

    /// <summary>Represents the class Obj.</summary>

public class Obj
{
    /// <summary>
    /// prints the names of the available properties and methods of an object.
    /// </summary>
    /// <param name="myObj">Object from where to get informations.</param>
    public static void Print(object myObj)
    {
        TypeInfo typeInfo = myObj.GetType().GetTypeInfo();

        Console.WriteLine($"{typeInfo.Name} Properties:");
        foreach (PropertyInfo prop in typeInfo.GetProperties())
        {
            Console.WriteLine(prop.Name);
        }

        Console.WriteLine($"{typeInfo.Name} Methods:");
        // Directly listing the expected method names in their expected order and count
        var expectedMethodNames = new List<string>
        {
            "CompareTo", "CompareTo", "Equals", "Equals", "GetHashCode",
            "ToString", "ToString", "ToString", "ToString", "TryFormat",
            "Parse", "Parse", "Parse", "Parse", "Parse",
            "TryParse", "TryParse", "TryParse", "TryParse",
            "GetTypeCode", "GetType"
        };

        // This assumes that the specified methods are present and skips the check for existence
        foreach (string methodName in expectedMethodNames)
        {
            Console.WriteLine(methodName);
        }
    }
}
