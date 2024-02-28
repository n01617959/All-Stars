using System;
using System.Collections.Generic;

namespace RestaurantManagementSystem
{
    public class InventoryDb
    {
        private List<Inventory> _inventory;

        public InventoryDb()
        {
            _inventory = new List<Inventory>();
        }

        public void AddInventory(Inventory inventory)
        {
            _inventory.Add(inventory);
        }

        public void UpdateInventory(Inventory inventory)
        {
            var existingInventory = _inventory.Find(i => i.ItemID == inventory.ItemID);
            if (existingInventory != null)
            {
                existingInventory.ItemName = inventory.ItemName;
                existingInventory.Quantity = inventory.Quantity;
                existingInventory.Category = inventory.Category;
                existingInventory.Price = inventory.Price;
                existingInventory.Description = inventory.Description;
            }
            else
            {
                throw new InvalidOperationException("Inventory item not found for update.");
            }
        }

        public void RemoveInventory(int itemID)
        {
            var inventoryToRemove = _inventory.Find(i => i.ItemID == itemID);
            if (inventoryToRemove != null)
            {
                _inventory.Remove(inventoryToRemove);
            }
            else
            {
                throw new InvalidOperationException("Inventory item not found for removal.");
            }
        }

        public List<Inventory> GetInventory()
        {
            return _inventory;
        }
    }
}
