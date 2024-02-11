namespace Enemies
{
    /// <summary>
    /// Represents a Zombie within the game environment, with encapsulated health attribute.
    /// </summary>
    public class Zombie
    {
        private int health;

        /// <summary>
        /// Initializes a new instance of the <see cref="Zombie"/> class with health set to 0.
        /// </summary>
        public Zombie()
        {
            health = 0;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Zombie"/> class with a specified health value.
        /// </summary>
        /// <param name="value">The initial health value of the zombie. Must be greater than or equal to 0.</param>
        /// <exception cref="System.ArgumentException">Thrown when the health value is less than 0.</exception>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new System.ArgumentException("Health must be greater than or equal to 0");
            }
            health = value;
        }

        /// <summary>
        /// Retrieves the health value of the zombie.
        /// </summary>
        /// <returns>The current health of the zombie.</returns>
        public int GetHealth()
        {
            return health;
        }
    }
}
