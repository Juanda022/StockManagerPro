using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockManagerPro{

    public class Purchases
    {
        public int purchaseID;
        public int supplierID;
        public DateTime purchaseDate;
        public float totalAmount;

        public Purchases()
        {
            purchaseID = 0;
            supplierID = 0;
            purchaseDate = DateTime.Now;
            totalAmount = 0;
        }
        public Purchases(int purchaseID, int supplierID, DateTime purchaseDate, float totalAmount)
        {
            this.purchaseID = purchaseID;
            this.supplierID = supplierID;
            this.purchaseDate = purchaseDate;
            this.totalAmount = totalAmount;
        }

        public int PurchaseID
        {
            get { return purchaseID; }
            set { purchaseID = value; }
        }
        public int SupplierID
        {
            get { return supplierID; }
            set { supplierID = value; }
        }
        public DateTime PurchaseDate
        {
            get { return purchaseDate; }
            set { purchaseDate = value; }
        }
        public float TotalAmount
        {
            get { return totalAmount; }
            set { totalAmount = value; }
        }
    }
}