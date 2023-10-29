using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockManagerPro{

    public class User
    {
        private int userID;
        private string userPassword;
        private string userRole;

        public User()
        {
            userID = 0;
            userPassword = "";
            userRole = "";
        }
        public User(int userID, string userPassword, string userRole)
        {
            this.userID = userID;
            this.userPassword = userPassword;
            this.userRole = userRole;
        }

        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        public string UserPassword
        {
            get { return userPassword; }
            set { userPassword = value; }
        }
        public string UserRole
        {
            get { return userRole; }
            set { userRole = value; }
        }
    }
}