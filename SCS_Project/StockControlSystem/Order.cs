using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockControlSystem
{
    public class Order
    {
        // Item Key
        private int _itemKey;
        // Order date
        private string _datePlaced;
        // Order quantity of item
        private int _quantity;
        // Item being ordered
        private Item _orderItem;

        /*
         * Order constructor
         * Parameters: Date Placed, Quantity, Item
         */
        public Order(string dp, int q, Item oi)
        {
            _datePlaced = dp;
            _quantity = q;
            _orderItem = oi;
            _itemKey = _orderItem.getKey();
        }

        /*
         * Get order item key.
         */
        public int getKey()
        {
            return _itemKey;
        }

        /*
         * Execute the order by adding the stock
         * to the item's quantity.
         */
        public void executeOrder()
        {
            _orderItem.addStock(_quantity);
        }

        /*
         * Override toString() method - return order details in string form
         */
        public override string ToString()
        {
            return _datePlaced + " [" + _quantity + "]:  " + _orderItem.ToString();
        }
    }
}
