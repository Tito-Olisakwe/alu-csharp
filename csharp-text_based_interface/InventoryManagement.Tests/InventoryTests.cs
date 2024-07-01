using System;
using System.Collections.Generic;
using Xunit;
using InventoryLibrary;

namespace InventoryManagement.Tests
{
    public class InventoryTests
    {
        [Fact]
        public void Test_Create_Item()
        {
            var item = new Item { name = "Laptop", price = 999.99f, description = "A high-end gaming laptop", tags = new List<string> { "electronics", "gaming" } };
            Assert.Equal("Laptop", item.name);
            Assert.Equal(999.99f, item.price);
            Assert.Equal("A high-end gaming laptop", item.description);
            Assert.Contains("electronics", item.tags);
            Assert.Contains("gaming", item.tags);
        }

        [Fact]
        public void Test_Create_User()
        {
            var user = new User { name = "John Doe" };
            Assert.Equal("John Doe", user.name);
        }

        [Fact]
        public void Test_Create_Inventory()
        {
            var user = new User { name = "John Doe" };
            var item = new Item { name = "Laptop", price = 999.99f };
            var inventory = new Inventory { user_id = user.id, item_id = item.id, quantity = 5 };
            Assert.Equal(user.id, inventory.user_id);
            Assert.Equal(item.id, inventory.item_id);
            Assert.Equal(5, inventory.quantity);
        }

        [Fact]
        public void Test_JSONStorage_Save_And_Load()
        {
            var storage = new JSONStorage();
            var user = new User { name = "John Doe" };
            var item = new Item { name = "Laptop", price = 999.99f };
            var inventory = new Inventory { user_id = user.id, item_id = item.id, quantity = 5 };

            storage.New(user);
            storage.New(item);
            storage.New(inventory);
            storage.Save();

            var newStorage = new JSONStorage();
            newStorage.Load();

            Assert.Equal(3, newStorage.All().Count);
            Assert.True(newStorage.All().ContainsKey($"User.{user.id}"));
            Assert.True(newStorage.All().ContainsKey($"Item.{item.id}"));
            Assert.True(newStorage.All().ContainsKey($"Inventory.{inventory.id}"));
        }

        [Fact]
        public void Test_Invalid_ClassName()
        {
            var storage = new JSONStorage();
            var input = "invalidClassName";
            var result = storage.All().ContainsKey(input);

            Assert.False(result);
        }

        [Fact]
        public void Test_Invalid_Object_ID()
        {
            var storage = new JSONStorage();
            var user = new User { name = "John Doe" };
            storage.New(user);
            storage.Save();

            var invalidId = "invalidID";
            var key = $"User.{invalidId}";

            Assert.False(storage.All().ContainsKey(key));
        }

        [Fact]
        public void Test_Update_Object()
        {
            var storage = new JSONStorage();
            var user = new User { name = "John Doe" };
            storage.New(user);
            storage.Save();

            user.name = "Jane Doe";
            storage.Save();
            storage.Load();

            var key = $"User.{user.id}";
            var updatedUser = (User)storage.All()[key];

            Assert.Equal("Jane Doe", updatedUser.name);
        }

        [Fact]
        public void Test_Delete_Object()
        {
            var storage = new JSONStorage();
            var user = new User { name = "John Doe" };
            storage.New(user);
            storage.Save();

            var key = $"User.{user.id}";
            storage.All().Remove(key);
            storage.Save();
            storage.Load();

            Assert.False(storage.All().ContainsKey(key));
        }
    }
}
