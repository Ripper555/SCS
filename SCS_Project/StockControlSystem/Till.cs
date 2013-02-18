using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StockControlSystem
{
    public partial class Till : Form
    {
        ControlSystem syst;
        Transaction currentTransaction;

        public Till(ControlSystem s)
        {
            InitializeComponent();
            syst = s;
        }

        public string BarCode
        {
            get
            {
                return tbBarCode.Text.Trim();
            }
        }

        public void ClearBarCode()
        {
            tbBarCode.Text = string.Empty;
        }

        public string ItemName
        {
            get
            {
                return tbName.Text.Trim();
            }
        }

        public void DisplayItemName(string name)
        {
            tbName.Text = name;
        }

        public void ClearItemName()
        {
            tbName.Text = String.Empty;
        }

        public string ItemPrice
        {
            get
            {
                return tbPrice.Text.Trim();
            }
        }

        public void DisplayItemPrice(string price)
        {
            tbPrice.Text = price;
        }

        public void ClearItemPrice()
        {
            tbPrice.Text = string.Empty;
        }


        private void bnScan_Click(object sender, EventArgs e)
        {
            if (currentTransaction == null) currentTransaction = new Transaction();
            try
            {
                int bc = int.Parse(tbBarCode.Text);
                Item i = syst.locateItem(bc);
                currentTransaction.addItem(i);
                tbName.Text = i.getName();
                tbPrice.Text = String.Format("{0:0.00}", i.getPrice());
            }
            catch { MessageBox.Show("Item not found"); }

            tbBarCode.Text = "";
        }

        private void bnTotal_Click(object sender, EventArgs e)
        {
            if (currentTransaction == null) MessageBox.Show("No current Transaction");
            else
            {
                currentTransaction.executeTransaction();

                List<string> sl = currentTransaction.displayItems();
                if (sl != null)
                {
                    ListDialog listDialog = new ListDialog();
                    listDialog.AddDisplayItems(sl.ToArray());
                    listDialog.ShowDialog();

                    syst.addTransaction(currentTransaction);
                }
                currentTransaction = null;
            }

            tbName.Text = "";
            tbPrice.Text = "";
        }

        private void bnBalance_Click(object sender, EventArgs e)
        {
            ListDialog listDialog = new ListDialog();
            listDialog.AddDisplayItems(syst.listTransactions());
            listDialog.ShowDialog();
        }

        private void bnClear_Click(object sender, EventArgs e)
        {
            syst.clearTransaction();
            tbName.Text = "";
            tbPrice.Text = "";
            currentTransaction = null;
        }

        private void Till_Load(object sender, EventArgs e)
        {

        }
    }
}
