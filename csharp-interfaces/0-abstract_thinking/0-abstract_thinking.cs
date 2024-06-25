#nullable enable

using System;

/// <summary>
/// Base class providing foundational properties for inheritance.
/// </summary>
abstract class Base
{
    /// <summary>
    /// Gets or sets the name associated with the instance.
    /// </summary>
    public string name? {get; set;}

    /// <summary>
    /// Overrides the default ToString() method to display custom properties.
    /// </summary>
    /// <returns>A string representation of the object, including its name and type.</returns>
    public override string ToString()
    {
        return $"{name} is a {this.GetType()}";
    }
}
