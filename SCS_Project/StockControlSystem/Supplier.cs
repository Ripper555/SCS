using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockControlSystem
{
    public class Supplier
    {
        // Supplier Phone #
        private string _phoneNumber;
        // Supplier Name
        private string _name;
        // Supplier Address
        private string _address;

        // Supplier Key identifier
        public int Key { get; set; }

        /*
         * Supplier constructor
         * Parameters: Phone Number, Name, Address, Key
         */
        public Supplier(string pn, string n, string a, int k)
        {
            _phoneNumber = pn;
            _name = n;
            _address = a;
            Key = k;
        }

        /*
         * Compare parameter key to this supplier's key for identification purposes.
         */
        public bool checkKey(int k)
        {
            if (Key == k) return true;

            return false;
        }

        /*
         * Overrides toString() method - returns basic Supplier information in string form.
         */
        public override string ToString()
        {
            return Key + ": " + _name + ", " + _address + ", " + _phoneNumber;
        }

    }
}
