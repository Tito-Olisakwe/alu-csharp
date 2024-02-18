using System;

/// <summary>
/// Contains methods for checking instances and inheritance.
/// </summary>
public class Obj
{
    /// <summary>
    /// Checks if the given object is an instance of, or inherits from, Array.
    /// </summary>
    /// <param name="obj">The object to check.</param>
    /// <returns>True if obj is an instance of type array or inherits from type array, otherwise false.</returns>
    public static bool IsInstanceOfArray(object obj)
    {
        return obj.GetType().IsArray;
    }
}
