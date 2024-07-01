using System;

namespace InventoryLibrary
{
    /// <summary>
    /// Class representing an inventory entry
    /// </summary>
    public class Inventory : BaseClass
    {
        /// <summary>
        /// ID of the user associated with this inventory entry
        /// </summary>
        public string user_id { get; set; }

        /// <summary>
        /// ID of the item associated with this inventory entry
        /// </summary>
        public string item_id { get; set; }

        /// <summary>
        /// Quantity of the item, default value is 1 and cannot be less than 0
        /// </summary>
        private int _quantity;
        public int quantity 
        { 
            get { return _quantity; } 
            set 
            { 
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Quantity cannot be less than 0");
                _quantity = value;
            } 
        }

        /// <summary>
        /// Constructor to initialize the inventory entry
        /// </summary>
        public Inventory()
        {
            this.quantity = 1;
        }
    }
}
