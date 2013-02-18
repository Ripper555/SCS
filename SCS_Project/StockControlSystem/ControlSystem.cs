using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockControlSystem
{
    public class ControlSystem
    {
        // Item List
        private List<Item> _itemList;
        // Supplier List
        private List<Supplier> _supplierList;
        // Order List
        private List<Order> _orderList;
        // Transaction List
        private List<Transaction> _transactionList;

        /*
         * Control System Constructor - Initialize all of the system lists.
         */ 
        public ControlSystem()
        {
            _itemList = new List<Item>();
            _supplierList = new List<Supplier>();
            _orderList = new List<Order>();
            _transactionList = new List<Transaction>();
        }

        /*
         * Locate an item from the list by the bar code.
         */
        public Item locateItem(int bC)
        {
            return _itemList.Find(i => i.getBarCode() == bC);
        }

        /*
        * Locate an item from the list by the item key.
        */
        public Item locateItemKey(int k)
        {
            return _itemList.Find(i => i.getKey() == k);
        }

        /*
         * Add a Supplier to the list.
         */
        public void addSupplier(Supplier s)
        {
            _supplierList.Add(s);
        }

        /*
         * Add an item to the list.
         */
        public void addItem(Item i)
        {
            _itemList.Add(i);
        }

        /*
         * Add a transaction to the list.
         */
        public void addTransaction(Transaction t)
        {
            _transactionList.Add(t);
        }

        /*
         * Called to clear the transaction list.
         */
        public void clearTransaction()
        {
            _transactionList.Clear();
        }

        /*
         * Returns a list of suppliers in the form of a string array.
         */
        public string[] listSuppliers()
        {
            string[] s = new string[_supplierList.Count()];

            // Iterate through supplier list and insert the names
            // of all suppliers into the string array.
            int i = 0;
            foreach (Supplier sp in _supplierList)
            {
                s[i] = sp.ToString();
                i++;
            }
            return s;
        }

        /*
         * Returns a list of Items in the form of a string array.
         */
        public string[] listStock()
        {
            string[] s = new string[_itemList.Count()];

            // Iterate through the item list and insert the names
            // of all the items into the string array.
            int i = 0;
            foreach (Item it in _itemList)
            {
                s[i] = it.ToString();
                i++;
            }
            return s;
        }

        /*
         *  List items that have a stock count below or at the 
         *  reorder threshhold.
         */
        public string[] listScarceStock()
        {
            List<string> s = new List<string>();

            // Iterate through the item list and add items that
            // are low in stock to the result list.
            foreach (Item it in _itemList)
            {
                if (it.checkScarce()) s.Add(it.ToString());
            }

            return s.ToArray();
        }

        /*
         * Add an order to the Order List.
         * Parameters: Order Date, quantity and item key.
         */
        public void addOrder(string date, int q, int k)
        {
            _orderList.Add(new Order(date, q, locateItemKey(k)));
        }

        /*
         * Locate an order by its order key.
         */
        public Order locateOrder(int k)
        {
            return _orderList.Find(o => o.getKey() == k);
        }

        /*
         * Locate a Supplier by its supplier key.
         */
        public Supplier locateSupplier(int k)
        {
            return _supplierList.Find(s => s.Key == k);
        }

        /*
         * Remove an order from the list after executing it first.
         */
        public void removeOrder(int key)
        {
            Order temp = locateOrder(key);
            temp.executeOrder();
            _orderList.Remove(temp);
        }

        /*
         * Total all current transactions in the list.
         */
        public double totalTransactions()
        {
            // Running total
            double total = 0;

            // Iterate through each transaction and add
            // the order total to the running total.
            foreach (Transaction t in _transactionList)
            {
                t.totalTransaction();
                total += t.getTotal();
            }

            return total;
        }

        /*
         * List the current list of transactions - returns in string array form.
         */
        public string[] listTransactions()
        {
            List<string> sl = new List<string>();
            foreach (Transaction t in _transactionList)
            {
                sl.AddRange(t.displayItems());
            }

            sl.Add("========================================");
            sl.Add("Total for the Day = " + String.Format("{0:0.00}", totalTransactions()));

            return sl.ToArray();
        }

        /*
         * List current orders - returns in string array form.
         */
        public string[] listOrders()
        {
            List<string> sl = new List<string>();
            foreach (Order o in _orderList)
            {
                sl.Add(o.ToString());
            }

            return sl.ToArray();
        }

        /*
         * Clear the transaction list.
         */
        public void removeTransactions()
        {
            _transactionList.Clear();
        }
        
    }
}
