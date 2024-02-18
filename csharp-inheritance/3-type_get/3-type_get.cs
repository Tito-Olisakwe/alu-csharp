using System;
using System.Reflection;
using System.Collections.Generic;

/// <summary>
/// Provides functionality to print details of objects.
/// </summary>
public class Obj
{
    /// <summary>
    /// Prints the names of the available properties and methods of an object.
    /// </summary>
    /// <param name="myObj">The object to inspect.</param>
    public static void Print(object myObj){

        TypeInfo t =  myObj.GetType().GetTypeInfo();
        IEnumerable<PropertyInfo> pList = t.GetProperties();
        Console.WriteLine($"{t.Name} Properties:");

        foreach(PropertyInfo p in pList){
            Console.WriteLine(p.Name);
        }

        IEnumerable<MethodInfo> pMethod = t.GetMethods();
        Console.WriteLine($"{t.Name} Methods:");

        foreach(MethodInfo m in pMethod){
            if(m.DeclaringType == myObj.GetType()){
                 Console.WriteLine(m.Name);
            }
        }
    }
}
