using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    public class AdminManager
    {
        private List<User> _validUsers;

        public AdminManager()
        {
            // Initialize the list of valid users
            _validUsers = new List<User>
            {
                new User { Username = "Admin", Password = "abc" },
                // Add more valid users if needed
            };
        }

        public bool ValidateUser(string username, string password)
        {
            foreach (var user in _validUsers)
            {
                if (user.Username == username && user.Password == password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
