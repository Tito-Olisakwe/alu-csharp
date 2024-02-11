using Enemies;
using System;

namespace Enemies
{
    /// <summary>
    /// Represents a Zombie within the game environment, with health as a defining attribute.
    /// </summary>
    public class Zombie
    {
        /// <summary>
        /// Represents the health of the Zombie.
        /// </summary>
        public int health;

        /// <summary>
        /// Initializes a new instance of the <see cref="Zombie"/> class with health set to 0.
        /// </summary>
        public Zombie()
        {
            health = 0;
        }
    }
}


class Program
{
    static void Main(string[] args)
    {
        Enemies.Zombie newObject = new Enemies.Zombie();

        Console.WriteLine("newObject is of type {0} and has a total of {1} health", newObject.GetType(), newObject.health);
    }
}