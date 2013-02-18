using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StockControlSystem
{
    public class Transaction
    {
        // Transaction total
        private double _total;
        // List of items for the current transaction
        private List<TransactionItem> _transactionItemList;

        /*
         * Transaction Constructor - Initializes Item list for the transaction object
         */
        public Transaction() 
        {
            _transactionItemList = new List<TransactionItem>();
        }

        /*
         * Adds an item to the current transaction
         * Parameter: Item to add
         */
        public void addItem(Item i)
        {
            // Display an alert if the item is out of stock.
            if (i.getQuantity() <= 0) MessageBox.Show(i.getName() + "is out of stock");
            else
            {
                // Create a transaction item object for current transaction
                TransactionItem ti = checkItem(i.getBarCode());
                if (ti == null) _transactionItemList.Add(new TransactionItem(i));
                else ti.incrementQuantity();
                
            }
        }

        /*
         * 
         */
        public TransactionItem checkItem(int barCode)
        {
            return _transactionItemList.Find(ti => ti.getBarCode() == barCode);
        }

        /*
         * Total and complete the current transaction.
         */
        public void totalTransaction()
        {
            _total = 0;

            // Iterate through all items in the list and add up the total.
            foreach (TransactionItem ti in _transactionItemList)
            {
                _total += ti.getPrice();
            }
        }

        /*
         * Execute the current transaction.
         */
        public void executeTransaction()
        {
            // Iterate through all items and execute the transaction
            foreach (TransactionItem ti in _transactionItemList)
            {
                ti.executeTransaction();
            }
          
            totalTransaction();
        }

        /*
         * Return total for transaction
         */
        public double getTotal()
        {
            return _total;
        }

        /*
         * Return all the items in the current transaction as a list of strings.
         */
        public List<string> displayItems()
        {
            if (_transactionItemList.Count() > 0)
            {
                List<string> sl = new List<string>();

                foreach (TransactionItem ti in _transactionItemList)
                {
                    sl.Add(ti.ToString());
                }

                sl.Add("-------------------------------------");
                sl.Add("\t\tTotal = " + String.Format("{0:0.00}", _total));

                return sl;
            }
            return null;
        }
    }
}
