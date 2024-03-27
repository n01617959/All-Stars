using System.Collections.Generic;

namespace RestaurantManagementSystem
{
    public class InventoryManager
    {
        private InventoryDb _inventoryDb;

        public InventoryManager()
        {
            _inventoryDb = new InventoryDb();
        }

        public void AddInventory(Inventory inventory)
        {
            _inventoryDb.AddInventory(inventory);
        }

        public void UpdateInventory(Inventory inventory)
        {
            _inventoryDb.UpdateInventory(inventory);
        }

        public void RemoveInventory(int itemID)
        {
            _inventoryDb.RemoveInventory(itemID);
        }

        public List<Inventory> GetInventory()
        {
            return _inventoryDb.GetInventory();
        }



        public List<Inventory> GetSubCategoriesByCategory(string category)
        {
            return _inventoryDb.GetSubCategoriesByCategory(category);
        }
    }
}
