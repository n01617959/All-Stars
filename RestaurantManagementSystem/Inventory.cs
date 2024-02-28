using System;

namespace RestaurantManagementSystem
{
    public class Inventory
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }



        // Constructor for convenience
        public Inventory(int itemId, string itemName, int quantity, string category, decimal price, string description)
        {
            ItemID = itemId;
            ItemName = itemName;
            Quantity = quantity;
            Category = category;
            Price = price;
            Description = description;
        }
    }


     
}
