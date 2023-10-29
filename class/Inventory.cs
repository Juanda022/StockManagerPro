using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockManagerPro{

    public class Inventory
    {
        private int productID;
        private string productName;
        private string productDescription;
        private float price;
        private int stockQuantity;
        private int supplierID;

        public Inventory()
        {
            productID = 0;
            productName = "";
            productDescription = "";
            price = 0;
            stockQuantity = 0;
            supplierID = 0;
        }
        public Inventory(int productID, string productName, string productDescription, float price, int stockQuantity, int supplierID)
        {
            this.productID = productID;
            this.productName = productName;
            this.productDescription = productDescription;
            this.price = price;
            this.stockQuantity = stockQuantity;
            this.supplierID = supplierID;
        }
        
        public int ProductID 
        { 
            get {  return productID; } 
            set { productID = value; }
        }

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        public string ProductDescription
        {
            get { return productDescription; }
            set { productDescription = value; }
        }
        public float Price
        {
            get { return price; }
            set { price = value; }
        }
        public int StockQuantity
        {
            get { return stockQuantity; }
            set { stockQuantity = value; }
        }
        public int SupplierID
        { 
            get { return supplierID; } 
            set { supplierID = value; } 
        }
    }   
}