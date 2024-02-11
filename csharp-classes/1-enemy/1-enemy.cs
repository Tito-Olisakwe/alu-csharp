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
