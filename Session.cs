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

        public static bool IsLoggedIn => !string.IsNullOrEmpty(CurrentUser);

        public static void Login(int userID,string username)
        {
            CurrentUser = username;
            UserID = userID;
        }

        public static void Logout()
        {
            CurrentUser = null;
            UserID = 0;
        }
    }
}
