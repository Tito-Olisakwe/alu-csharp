using System;

/// <summary>
/// Contains methods for type checking.
/// </summary>
public class Obj
{
    /// <summary>
    /// Checks if the given object is of type int.
    /// </summary>
    /// <param name="obj">The object to check.</param>
    /// <returns>True if obj is an int, otherwise false.</returns>
    public static bool IsOfTypeInt(object obj)
    {
        return obj is int;
    }
}
