using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker
{
    public static class Session
    {
        public static string CurrentUser { get; private set; }
        public static int UserID { get; private set; }
        public static string UserFullName { get; private set; }

        public static bool IsLoggedIn => !string.IsNullOrEmpty(CurrentUser);

        public static void Login(int userID,string username, string name)
        {
            CurrentUser = username;
            UserFullName = name;
            UserID = userID;
        }

        public static void Logout()
        {
            CurrentUser = null;
            UserFullName = null;
            UserID = 0;
        }
    }
}
