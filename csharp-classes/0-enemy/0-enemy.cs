namespace Enemies
{
    /// <summary>
    /// Defines a Zombie within the game environment.
    /// </summary>
    public class Zombie
    {
    }
}

class Program
{
    static void Main(string[] args)
    {
        Enemies.Zombie newObject = new Enemies.Zombie();
        System.Console.WriteLine("newObject is of type {0}", newObject.GetType());
        System.Console.WriteLine("String representation: {0}", newObject.ToString());
    }
}
