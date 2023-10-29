using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockManagerPro{

    public class FoodMovement
    {
        private int movementID;
        private int productID;
        private string movementType;
        private int quantity;
        private DateTime dateTime;

        public FoodMovement()
        {
            movementID = 0;
            productID = 0;
            movementType = "";
            quantity = 0;
            dateTime = DateTime.Now;
        }
        public FoodMovement(int movementID, int productID, string movementType, int quantity, DateTime dateTime)
        {
            this.movementID = movementID;
            this.productID = productID;
            this.movementType = movementType;
            this.quantity = quantity;
            this.dateTime = dateTime;
        }

        public int MovementID
        {
            get { return movementID; }
            set { movementID = value; }
        }

        public int ProductID
        {
            get { return productID; }
            set { productID = value; }
        }

        public string MovementType
        {
            get { return movementType; }
            set { movementType = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public DateTime DateTime
        {
            get { return dateTime; }
            set { dateTime = value; }
        }
    }
}