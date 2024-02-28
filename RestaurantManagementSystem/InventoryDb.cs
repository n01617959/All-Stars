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
            Inventory existingInventory = null;

            // Manually search for the inventory item
            foreach (var item in _inventory)
            {
                if (item.ItemID == inventory.ItemID)
                {
                    existingInventory = item;
                    break; // Exit the loop once the item is found
                }
            }

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
            Inventory inventoryToRemove = null;

            // Manually search for the inventory item to remove
            foreach (var item in _inventory)
            {
                if (item.ItemID == itemID)
                {
                    inventoryToRemove = item;
                    break; 
                }
            }

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
