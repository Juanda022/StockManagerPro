using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockManagerPro{

    public class Sales
    {
        private int saleID;
        private int customerID;
        private DateTime saleDate;
        private float totalAmount;
        public Sales()
        {
            saleID = 0;
            customerID = 0;
            saleDate = DateTime.Now;
            totalAmount = 0;
        }
        public Sales(int saleID, int customerID, DateTime saleDate, float totalAmount)
        {
            this.saleID = saleID;
            this.customerID = customerID;
            this.saleDate = saleDate;
            this.totalAmount = totalAmount;
        }

        public int SaleID
        {
            get { return saleID; }
            set { saleID = value; }
        }

        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }
        public DateTime SaleDate
        {
            get { return saleDate; }
            set { saleDate = value; }
        }

        public float TotalAmount
        {
            get { return totalAmount; }
            set { totalAmount = value; }
        }
    }
}