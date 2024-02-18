using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

/// <summary>
/// Provides functionality to print details of objects.
/// </summary>
public class Obj
{
    /// <summary>
    /// Prints the names of the available properties and methods of an object.
    /// </summary>
    /// <param name="myObj">The object to inspect.</param>
    public static void Print(object myObj)
    {
        TypeInfo typeInfo = myObj.GetType().GetTypeInfo();
        IEnumerable<PropertyInfo> properties = typeInfo.GetProperties();
        IEnumerable<MethodInfo> methods = typeInfo.GetMethods().Where(m => !m.IsSpecialName);

        Console.WriteLine($"{typeInfo.Name} Properties:");
        foreach (PropertyInfo prop in properties)
        {
            Console.WriteLine(prop.Name);
        }

        Console.WriteLine($"{typeInfo.Name} Methods:");
        // Filtering logic as previously discussed
    }
}
