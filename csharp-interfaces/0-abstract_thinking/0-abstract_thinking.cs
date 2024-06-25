#nullable enable

using System;

class Program
{
    static void Main()
    {
    }
}

/// <summary>
/// Base class providing foundational properties for inheritance.
/// </summary>
public abstract class Base
{
    /// <summary>
    /// Gets or sets the name associated with the instance.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Overrides the default ToString() method to display custom properties.
    /// </summary>
    /// <returns>A string representation of the object, including its name and type.</returns>
    public override string ToString()
    {
        return $"{Name} is a {this.GetType()}";
    }
}
