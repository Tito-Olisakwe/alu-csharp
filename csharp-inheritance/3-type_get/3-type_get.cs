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
        Type type = myObj.GetType();
        Console.WriteLine($"{type.Name} Properties:");
        foreach (var prop in type.GetProperties())
        {
            Console.WriteLine(prop.Name);
        }

        Console.WriteLine($"{type.Name} Methods:");
        var methods = type.GetMethods().Where(m => !m.IsSpecialName && m.DeclaringType == type);

        // Example of a type-specific filter (conceptual, not fully implemented)
        var filteredMethods = methods.Select(m => m.Name).Distinct();
        if (type == typeof(String))
        {
            // Add or remove specific methods for the String type
            filteredMethods = filteredMethods.Where(name => !name.StartsWith("get_") && !name.StartsWith("set_"));
        }
        // Additional type checks and filters could be added here

        foreach (var methodName in filteredMethods.OrderBy(name => name))
        {
            Console.WriteLine(methodName);
        }
    }
}