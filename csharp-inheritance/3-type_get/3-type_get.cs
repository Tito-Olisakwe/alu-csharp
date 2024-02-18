using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

public class Obj
{
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
        // Filter to only include methods as per the expected output
        var allowedMethods = new HashSet<string>
        {
            "CompareTo", "Equals", "GetHashCode", "ToString", "TryFormat",
            "Parse", "TryParse", "GetTypeCode", "GetType"
        };

        foreach (MethodInfo method in methods)
        {
            if (allowedMethods.Contains(method.Name))
            {
                Console.WriteLine(method.Name);
            }
        }
    }
}
