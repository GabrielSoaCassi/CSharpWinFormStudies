using System.Collections.Generic;
using System.Linq;

namespace LoginSystem.Model
{
    public static class SignUpUser
    {
        private static List<User> _existentsUser = new List<User>()
        {
            new User("Alice", "1234"),
            new User("Bob", "1234"),
            new User("Charlie", "1234"),
            new User("Diana", "1234"),
            new User("Eve", "1234")
        };
        private static User _loggedInUser;

        public static User LoggedInUser
        {
            get
            {
                return _loggedInUser;
            }
            private set
            {
                _loggedInUser = value;
            }
        }

        public static bool Login(User user)
        {
            LoggedInUser = _existentsUser.Find(u => u.Equals(user));
            if (_loggedInUser != null)
                return true;
            return false;
        }
    }
}