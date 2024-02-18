using System;
using System.Collections.Generic;
using System.Reflection;

/// <summary>Represents the class Obj.</summary>
class Obj
{
    /// <summary>
    /// prints the names of the available properties and methods of an object.
    /// </summary>
    /// <param name="myObj">Object from where to get informations.</param>
    public static void Print(object myObj)
{
    TypeInfo objTypeInfo = myObj.GetType().GetTypeInfo();
    Console.WriteLine($"{objTypeInfo.Name} Properties:");
    foreach (PropertyInfo prop in objTypeInfo.GetProperties())
    {
        Console.WriteLine(prop.Name);
    }

    Console.WriteLine($"{objTypeInfo.Name} Methods:");
    var allowedMethods = new HashSet<string>
    {
        "CompareTo", "Equals", "GetHashCode", "ToString", "TryFormat",
        "Parse", "TryParse", "GetTypeCode", "GetType"
    };
    foreach (MethodInfo method in objTypeInfo.GetMethods())
    {
        if (allowedMethods.Contains(method.Name))
        {
            Console.WriteLine(method.Name);
        }
    }
}
}