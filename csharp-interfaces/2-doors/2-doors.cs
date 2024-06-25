#nullable enable

using System;

/// <summary>
/// Base class providing foundational properties for inheritance.
/// </summary>
public abstract class Base
{
    /// <summary>
    /// Gets or sets the name associated with the instance. Nullable to allow for optional assignment.
    /// </summary>
    public string? name { get; set; }

    /// <summary>
    /// Overrides the default ToString() method to display custom properties.
    /// </summary>
    /// <returns>A string representation of the object, including its name and type.</returns>
    public override string ToString()
    {
        return $"{name} is a {this.GetType().Name}";
    }
}

/// <summary>
/// Interface defining interactive behavior.
/// </summary>
public interface IInteractive
{
    /// <summary>
    /// Method to define interaction behavior.
    /// </summary>
    void Interact();
}

/// <summary>
/// Interface defining breakable behavior.
/// </summary>
public interface IBreakable
{
    /// <summary>
    /// Gets or sets the durability of the object.
    /// </summary>
    int durability { get; set; }

    /// <summary>
    /// Method to define break behavior.
    /// </summary>
    void Break();
}

/// <summary>
/// Interface defining collectable behavior.
/// </summary>
public interface ICollectable
{
    /// <summary>
    /// Gets or sets the collection status of the object.
    /// </summary>
    bool isCollected { get; set; }

    /// <summary>
    /// Method to define collect behavior.
    /// </summary>
    void Collect();
}

/// <summary>
/// Class representing a door object that implements interactive behavior.
/// </summary>
public class Door : Base, IInteractive
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Door"/> class with a default or specified name.
    /// </summary>
    /// <param name="Name">The name of the door. Default is "Door".</param>
    public Door(string Name = "Door")
    {
        this.name = Name;
    }

    /// <summary>
    /// Method to define interaction behavior for the door.
    /// </summary>
    public void Interact()
    {
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}
