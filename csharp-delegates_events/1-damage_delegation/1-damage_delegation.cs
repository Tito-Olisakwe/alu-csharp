#nullable enable

using System;

/// <summary>
/// Delegate for calculating player's health.
/// </summary>
/// <param name="amount">The amount to modify the player's health by.</param>
public delegate void CalculateHealth(float amount);

/// <summary>
/// Represents a player character with health properties and methods.
/// </summary>
public class Player
{
    // Player's name.
    private string name { get; set; }
    // Player's maximum health points.
    private float maxHp { get; set; }
    // Player's current health points.
    private float hp { get; set; }

    /// <summary>
    /// Initializes a new instance of the Player class.
    /// </summary>
    /// <param name="name">The name of the player (default is "Player").</param>
    /// <param name="maxHp">The maximum health points of the player (default is 100f).</param>
    public Player(string name = "Player", float maxHp = 100f)
    {
        // Handle null or empty string for name
        this.name = !string.IsNullOrEmpty(name) ? name : "Player";

        if (maxHp <= 0)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            maxHp = 100f;
        }

        this.maxHp = maxHp;
        this.hp = maxHp;
    }

    /// <summary>
    /// Prints the name and current health of the player.
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

    /// <summary>
    /// Reduces the player's health by the specified damage amount.
    /// </summary>
    /// <param name="damage">The amount of damage taken by the player.</param>
    public void TakeDamage(float damage)
    {
        if (damage <= 0)
        {
            Console.WriteLine($"{name} takes 0 damage!");
            return;
        }

        hp = Math.Max(0, hp - damage);
        Console.WriteLine($"{name} takes {damage} damage!");
    }

    /// <summary>
    /// Increases the player's health by the specified healing amount.
    /// </summary>
    /// <param name="heal">The amount of health restored to the player.</param>
    public void HealDamage(float heal)
    {
        if (heal <= 0)
        {
            Console.WriteLine($"{name} heals 0 HP!");
            return;
        }

        hp = Math.Min(maxHp, hp + heal);
        Console.WriteLine($"{name} heals {heal} HP!");
    }
}
