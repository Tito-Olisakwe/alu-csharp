using System;
using System.Linq;
using System.Reflection;

/// <summary>
/// Provides functionality to print details of objects.
/// </summary>
public class Obj
{
    /// <summary>
    /// Prints the names of the available properties and methods of an object, excluding overloads.
    /// </summary>
    /// <param name="myObj">The object to inspect.</param>
    public static void Print(object myObj)
    {
        TypeInfo typeInfo = myObj.GetType().GetTypeInfo();

        Console.WriteLine($"{typeInfo.Name} Properties:");
        foreach (PropertyInfo prop in typeInfo.GetProperties())
        {
            Console.WriteLine(prop.Name);
        }

        Console.WriteLine($"{typeInfo.Name} Methods:");
        var methodNames = typeInfo.GetMethods()
                                   .Where(m => !m.IsSpecialName)
                                   .Select(m => m.Name)
                                   .Distinct();
        foreach (string name in methodNames)
        {
            Console.WriteLine(name);
        }
    }
}
