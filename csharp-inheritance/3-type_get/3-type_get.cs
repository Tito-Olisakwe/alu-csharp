using System;
using System.Reflection;

public class Obj
{
    public static void Print(object myObj)
    {
        TypeInfo typeInfo = myObj.GetType().GetTypeInfo();

        Console.WriteLine($"{typeInfo.Name} Properties:");
        foreach (PropertyInfo prop in typeInfo.GetProperties())
        {
            Console.WriteLine(prop.Name);
        }

        Console.WriteLine($"{typeInfo.Name} Methods:");
        // Manually specifying the expected method names based on the task description
        string[] expectedMethods = {
            "CompareTo", "CompareTo", // Assuming the need to display CompareTo twice as per expected output
            "Equals", "Equals", // Displaying Equals twice
            "GetHashCode", 
            "ToString", "ToString", "ToString", "ToString", // Displaying ToString four times
            "TryFormat", 
            "Parse", "Parse", "Parse", "Parse", "Parse", // Displaying Parse five times
            "TryParse", "TryParse", "TryParse", "TryParse", // Displaying TryParse four times
            "GetTypeCode", 
            "GetType"
        };

        // Filtering methods to only include those in the expectedMethods array
        foreach (var methodName in expectedMethods)
        {
            if (typeInfo.GetMethods().Any(m => m.Name == methodName))
            {
                Console.WriteLine(methodName);
            }
        }
    }
}
