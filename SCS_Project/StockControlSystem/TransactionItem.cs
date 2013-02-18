using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StockControlSystem
{
    public class TransactionItem
    {
        // Quantity of the item
        private int _quantity;
        // Item object
        private Item _transactionItem;
        // Bar code identifier of the object
        private int _barCode;

        /*
         * Transaction Item constructor
         * Parameters: Item object
         */
        public TransactionItem(Item ti)
        {
            // Set quantity at 1 initially
            _quantity = 1;
            _transactionItem = ti;
            _barCode = _transactionItem.getBarCode();
        }

        /*
         * Increments quantity - Called when item is scanned more than once per
         * transaction.
         */
        public void incrementQuantity()
        {
            if (_quantity < _transactionItem.getQuantity()) _quantity++;
            else MessageBox.Show(_transactionItem.getName() + " is out of stock");
        }

        /*
         * Get total for item - Multiply item price by quantity
         */
        public double getPrice()
        {
            return _transactionItem.getPrice() * _quantity;
        }

        /*
         * Return item bar code identifier
         */
        public int getBarCode()
        {
            return _barCode;
        }

        /*
         * Execute transaction by removing from current stock.
         */
        public void executeTransaction()
        {
            _transactionItem.removeStock(_quantity);
        }

        /*
         * Overrides toString() method - Returns item information and the current transaction quantity purchased.
         */
        public override string ToString()
        {
            return _transactionItem.listTransaction() + " --- " + _quantity;
        }
    }
}
