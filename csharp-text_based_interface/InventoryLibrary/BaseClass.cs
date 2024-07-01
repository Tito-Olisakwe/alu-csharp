using System;

namespace InventoryLibrary
{
    /// <summary>
    /// Base class that all other classes inherit from
    /// </summary>
    public class BaseClass
    {
        /// <summary>
        /// Unique identifier for the object
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Date and time when the object was created
        /// </summary>
        public DateTime date_created { get; set; }

        /// <summary>
        /// Date and time when the object was last updated
        /// </summary>
        public DateTime date_updated { get; set; }

        /// <summary>
        /// Constructor to initialize the object
        /// </summary>
        public BaseClass()
        {
            this.id = Guid.NewGuid().ToString();
            this.date_created = DateTime.Now;
            this.date_updated = DateTime.Now;
        }
    }
}
