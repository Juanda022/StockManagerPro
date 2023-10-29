using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockManagerPro{

    public class Cliente
    {
        private int customerID;
        private string customerName;
        private string customerAddress;
        private string customerPhone;
        private string customerEmail;

        public Cliente()
        {
            customerID = 0;
            customerName = "";
            customerAddress = "";
            customerPhone = "";
            customerEmail = "";
        }
        public Cliente(int clientID, string clientName, string clientAddress, string clientPhone, string clientEmail)
        {
            this.customerID = clientID;
            this.customerName = clientName;
            this.customerAddress = clientAddress;
            this.customerPhone = clientPhone;
            this.customerEmail = clientEmail;
        }

        public int ClientID 
        { 
            get { return customerID; } 
            set { customerID = value; } 
        }

        public string ClientName
        {
            get { return customerName; }
            set { customerName = value; }
        }

        public string ClientAddress
        {
            get { return customerAddress; }
            set { customerAddress = value; }
        }

        public string ClientPhone
        {
            get { return customerPhone; }
            set { customerPhone = value; }
        }
        public string ClientEmail
        {
            get { return customerEmail; }
        }
    }
}