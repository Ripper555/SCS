using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockControlSystem
{
    public class Item
    {
        // Item Name
        private string _itemName;
        // Current quantity in stock of item
        private int _stockQuantity;
        // Order Threshold - Stock is considered scarce when at or below this level.
        private int _orderThreshold;
        // Item price
        private double _retailPrice;
        // Item is scarce - if true item needs to be reordered
        private bool _isScarce;
        // Preffered Supplier for item
        private Supplier _preferredSupplier;
        // Item key (identifier)
        private int _key;
        // Item Bar Code
        private int _barCode;

        /*
         * Item constructor
         * Parameters: Bar Code, Item Name, Stock quantity, Order Threshold, Retail Price,
         * Item Key, and Preferred Supplier
         */
        public Item(int bc, string iN, int sq, int ot, double rp, int k, Supplier ps)
        {
            _barCode = bc;
            _itemName = iN;
            _stockQuantity = sq;
            _orderThreshold = ot;
            _retailPrice = rp;
            _key = k;
            _preferredSupplier = ps;

            // Checks for item scarcity
            stockCheck();
        }

        /*
         * Compares parameter bar code to item bar code for
         * identification purposes.
         */
        public bool compBarCode(int b) {
            if (_barCode == b) return true;

            return false;
        }

        /*
         * Add Stock of item
         * Parameter: Quantity
         */
        public void addStock(int q)
        {
            _stockQuantity += q;
            stockCheck();
        }

        /*
         * Remove stock of item
         * Parameter: Quantity
         */
        public void removeStock(int q)
        {
            _stockQuantity -= q;

            // Check for item scarcity
            stockCheck();
        }

        /*
         * Returns whether the item stock is scarce or not
         */
        public bool checkScarce()
        {
            return _isScarce;
        }

        /*
        * Checks if item is at or below order threshold.
        */
        public void stockCheck()
        {
            if (_stockQuantity <= _orderThreshold) _isScarce = true;
            else _isScarce = false;
        }

        /*
         * Returns the item and retail price for the purposes
         * of listing in a transaction.
         */
        public string listTransaction()
        {
            return _itemName + ": " + String.Format("{0:0.00}", _retailPrice);
        }

        /*
         * Return item name
         */
        public string getName()
        {
            return _itemName;
        }

        /*
         * Return current stock quantity
         */
        public int getQuantity()
        {
            return _stockQuantity;
        }

        /*
         * Returns the item's retail price
         */
        public double getPrice()
        {
            return _retailPrice;
        }

        /*
         * Returns the Bar code of the item.
         */
        public int getBarCode()
        {
            return _barCode;
        }

        /*
         * gets the key of the item.
         */
        public int getKey()
        {
            return _key;
        }

        /*
         * 
         */
        public Supplier getSupplier()
        {
            return _preferredSupplier;
        }

        /*
         * Overrides the toString() method - returns item information in string format.
         */ 
        public override string ToString()
        {
            return "{" + _key + "}" + _itemName + ", " + _barCode + ", " + _retailPrice + ", " 
                + _orderThreshold + ", " + _stockQuantity + "[" + _preferredSupplier.ToString() + "]";
        }
    }
}
