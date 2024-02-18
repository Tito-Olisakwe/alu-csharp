using System;
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
        TypeInfo objTypeInfo = myObj.GetType().GetTypeInfo();
        Console.WriteLine($"{objTypeInfo.Name} Properties:");
        foreach (PropertyInfo prop in objTypeInfo.GetProperties())
        {
            Console.WriteLine(prop.Name);
        }

        Console.WriteLine($"{objTypeInfo.Name} Methods:");
        foreach (MethodInfo method in objTypeInfo.GetMethods())
        {
            Console.WriteLine(method.Name);
        }
    }
}
