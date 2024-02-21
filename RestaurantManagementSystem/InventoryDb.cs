using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    internal class InventoryDb
    {
        List<Inventory> inventoryList = new List<Inventory>();

        public void AddInventory(Inventory inventory)
        {
            inventoryList.Add(inventory);
        }
        public void RemoveInventory(int itemID)
        {
            Inventory inventoryToRemove = inventoryList.Find(i => i.ItemID == itemID);

            if (inventoryToRemove != null)
            {
                inventoryList.Remove(inventoryToRemove);
            }
            else
            {
                // Handle the case where the inventory with the specified ItemID is not found
               MessageBox.Show("Inventory not found for removal.");
            }
        }

        public List<Inventory> GetInventory()
        {
            return inventoryList;
        }

        public void UpdateInventory(Inventory updatedInventory)
        {
            int index = inventoryList.FindIndex(i => i.ItemID == updatedInventory.ItemID);

            if (index != -1)
            {
                // Update the inventory at the found index
                inventoryList[index] = updatedInventory;
            }
            else
            {
                // Handle the case where the inventory with the specified ItemID is not found
                MessageBox.Show("Inventory not found for update.");
            }
        }

        public Inventory GetInventory(int itemID)
        {
            return inventoryList.Find(i => i.ItemID == itemID);
        }

    }
}
