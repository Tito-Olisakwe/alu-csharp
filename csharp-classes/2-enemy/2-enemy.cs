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

        /// <summary>
        /// Initializes a new instance of the <see cref="Zombie"/> class with a specified health value.
        /// </summary>
        /// <param name="value">The initial health value of the zombie.</param>
        /// <exception cref="System.ArgumentException">Thrown when the health value is less than 0.</exception>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new System.ArgumentException("Health must be greater than or equal to 0");
            }
            health = value;
        }
    }
}
