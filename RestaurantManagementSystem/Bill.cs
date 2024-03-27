using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    public class Bill
    {
        public int Item_No { get; set; }
        public string Sub_category { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public decimal Sub_Total { get; set; }
        public decimal HST { get; set; }
        public decimal Total { get; set; }

        public Bill(int item_No, string sub_category, string category, decimal price, decimal sub_Total, decimal hST, decimal total)
        {
            Item_No = item_No;
            Sub_category = sub_category;
            Category = category;
            Price = price;
            Sub_Total = sub_Total;
            HST = hST;
            Total = total;
        }
    }
}
