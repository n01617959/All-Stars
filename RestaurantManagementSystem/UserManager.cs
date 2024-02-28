using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    // This class is used to mange user operations
    public class UserManager
    {
        private List<User> _validUsers;

        public UserManager()
        {
            // Initialize the list of valid users
            _validUsers = new List<User>
            {
                new User { Username = "Allstars", Password = "123" },
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
            MessageBox.Show("The Username or Password you entered is incorrect, try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }
}
