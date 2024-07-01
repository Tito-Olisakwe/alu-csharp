using System;
using NUnit.Framework;
using InventoryLibrary;

namespace InventoryManagement.Tests
{
    [TestFixture]
    public class InventoryTests
    {
        [Test]
        public void Test_Create_Item()
        {
            var item = new Item { name = "Laptop", price = 999.99f };
            Assert.AreEqual("Laptop", item.name);
            Assert.AreEqual(999.99f, item.price);
        }

        [Test]
        public void Test_Create_User()
        {
            var user = new User { name = "John Doe" };
            Assert.AreEqual("John Doe", user.name);
        }

        [Test]
        public void Test_Create_Inventory()
        {
            var user = new User { name = "John Doe" };
            var item = new Item { name = "Laptop", price = 999.99f };
            var inventory = new Inventory { user_id = user.id, item_id = item.id, quantity = 5 };
            Assert.AreEqual(user.id, inventory.user_id);
            Assert.AreEqual(item.id, inventory.item_id);
            Assert.AreEqual(5, inventory.quantity);
        }
    }
}
