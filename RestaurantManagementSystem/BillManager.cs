using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    public class BillManager
    {
        private BillDB _billDb;

        public BillManager()
        {
            _billDb = new BillDB();
        }

        public void AddBill(Bill bill)
        {
            _billDb.AddBill(bill);
        }

        public void RemoveBill(int itemID)
        {
            _billDb.DeleteBill(itemID);
        }

        public List<Bill> GetBills()
        {
            return _billDb.GetAllBills();
        }
    }
}
