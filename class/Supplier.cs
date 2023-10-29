using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockManagerPro{

    public class Supplier
    {
        private int supplierID;
        private string supplierName;
        private string supplierAddress;
        private string supplierPhone;
        private string supplierEmail;

        public Supplier()
        {
            supplierID = 0;
            supplierName = "";
            supplierAddress = "";
            supplierPhone = "";
            supplierEmail = "";
        }

        public Supplier(int supplierID, string supplierName, string supplierAddress, string supplierPhone, string supplierEmail)
        {
            this.supplierID = supplierID;
            this.supplierName = supplierName;
            this.supplierAddress = supplierAddress;
            this.supplierPhone = supplierPhone;
            this.supplierEmail = supplierEmail;
        }

        public int SupplierID
        {
            get { return supplierID; }
            set { supplierID = value; }
        }

        public string SupplierName
        {
            get { return supplierName; }
            set { supplierName = value; }
        }

        public string SupplierAddress
        {
            get { return supplierAddress; }
            set { supplierAddress = value; }
        }

        public string SupplierPhone
        {
            get { return supplierPhone; }
            set { supplierPhone = value; }
        }
        public string SupplierEmail
        {
            get { return supplierEmail; }
            set { supplierEmail = value; }
        }
    }
}