using System;

namespace InventoryLibrary
{
    /// <summary>
    /// Class representing a user
    /// </summary>
    public class User : BaseClass
    {
        /// <summary>
        /// Name of the user
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Constructor to initialize the user with a name
        /// </summary>
        public User(string name)
        {
            this.name = name;
        }
    }
}
