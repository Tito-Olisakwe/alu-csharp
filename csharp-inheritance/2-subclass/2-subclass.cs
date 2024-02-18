using System;

/// <summary>
/// Contains methods for checking subclass relationships.
/// </summary>
public class Obj
{
    /// <summary>
    /// Checks if the derivedType is a subclass of the baseType.
    /// </summary>
    /// <param name="derivedType">The type to check.</param>
    /// <param name="baseType">The base type to compare against.</param>
    /// <returns>True if derivedType is a subclass of baseType, false otherwise.</returns>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        // Check if derivedType is a subclass of baseType
        // The condition also ensures that derivedType is not the same as baseType
        return derivedType.IsSubclassOf(baseType);
    }
}
