using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    internal class Inventory
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

        public Inventory() { }

        public Inventory(int itemID, string itemName, int quantity, string category, double price, string description)
        {
            ItemID = itemID;
            ItemName = itemName;
            Quantity = quantity;
            Category = category;
            Price = price;
            Description = description;
        }

    }
}
