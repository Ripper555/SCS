using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace StockControlSystem
{
    public partial class Computer : Form
    {
        private ControlSystem syst = new ControlSystem();
        private Boolean tillLoaded = false;

        public Computer()
        {
            InitializeComponent();
        }

        public string StockItemKeyToOrder
        {
            get
            {
                return tbOrderItemKey.Text.Trim();
            }
        }

        public void ClearStockItemKeyToOrder()
        {
            tbOrderItemKey.Text = string.Empty;
        }

        public string NumStockTiemsToOrder
        {
            get
            {
                return tbNumItemsToOrder.Text.Trim();
            }
        }

        public void ClearNumStockItemsToOrder()
        {
            tbNumItemsToOrder.Text = string.Empty;
        }

        public string StockItemKeyToRestock
        {
            get
            {
                return tbRestockItemKey.Text.Trim();
            }
        }

        public void ClearStockItemKeyToRestock()
        {
            tbRestockItemKey.Text = string.Empty;
        }


        private void Computer_Load(object sender, EventArgs e)
        {   
            // This handler is for initialization
        }


        private void bnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bnListStockBelowTH_Click(object sender, EventArgs e)
        {
            ListDialog listDialog = new ListDialog();
            listDialog.AddDisplayItems(syst.listScarceStock());
            listDialog.ShowDialog();
        }

        private void bnListAllStock_Click(object sender, EventArgs e)
        {
            ListDialog listDialog = new ListDialog();
            listDialog.AddDisplayItems(syst.listStock());
            listDialog.ShowDialog();
        }

        private void bnListAllSuppliers_Click(object sender, EventArgs e)
        {
            ListDialog listDialog = new ListDialog();
            listDialog.AddDisplayItems(syst.listSuppliers());
            listDialog.ShowDialog();
        }

        private void bnOrder_Click(object sender, EventArgs e)
        {
            try 
            { 
                int k = int.Parse(tbOrderItemKey.Text);
                int q = int.Parse(tbNumItemsToOrder.Text);
                DateTime time = DateTime.Now;
                syst.addOrder(time.ToString(), q, k);
            }
            catch { MessageBox.Show("Item Not Found");}

            tbOrderItemKey.Text = "";
            tbNumItemsToOrder.Text = "";
        }

        private void bnListOutstandingOrders_Click(object sender, EventArgs e)
        {
            ListDialog listDialog = new ListDialog();
            listDialog.AddDisplayItems(syst.listOrders());
            listDialog.ShowDialog();
        }

        private void bnRestock_Click(object sender, EventArgs e)
        {
            try
            {
                int k = int.Parse(tbRestockItemKey.Text);
                syst.removeOrder(k);
            }
            catch { MessageBox.Show("Item Not Found"); }

            tbRestockItemKey.Text = "";
        }

        private void bnLoadStock_Click(object sender, EventArgs e)
        {
            // load stock file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "StockItems|*.sti";
            openFileDialog.InitialDirectory = Application.StartupPath;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    TextReader trs = new StreamReader(openFileDialog.FileName);
                    string s;
                    string[] properties = new string[7];
                    char[] spliter = { '&' };
                    while ((s = trs.ReadLine()) != null)
                    {
                        properties = s.Split(spliter);

                        int k = int.Parse(properties[0]);
                        string n = properties[1];
                        int bc = int.Parse(properties[2]);
                        double p = double.Parse(properties[3]);
                        int t = int.Parse(properties[4]);
                        int q = int.Parse(properties[5]);
                        int sk = int.Parse(properties[6]);


                        syst.addItem(new Item(bc, n, q, t, p, k, syst.locateSupplier(sk)));
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Exception is caught (LoadSuppliers)");
                }
            }


            bnListStockBelowTH.Enabled = bnListAllStock.Enabled = bnListAllSuppliers.Enabled = true;
            bnListOutstandingOrders.Enabled = bnOrder.Enabled = bnRestock.Enabled = true;
            bnLoadSuppliers.Enabled = bnLoadStock.Enabled = false;

            if (!tillLoaded)
            {
                Till ts = new Till(syst);
                ts.Show();
                tillLoaded = true;
            }
            // I display Till here (using Show() since Till is a modeless dialog box
        }

        private void bnLoadSuppliers_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Suppliers|*.spl";
            openFileDialog.InitialDirectory = Application.StartupPath;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    TextReader trs = new StreamReader(openFileDialog.FileName);
                    string s;
                    string[] properties = new string[4];
                    char[] spliter = { '&' };
                    while ((s = trs.ReadLine()) != null)
                    {
                        properties = s.Split(spliter);

                        int k = int.Parse(properties[0]);
                        string n = properties[1];
                        string a = properties[2];
                        string t = properties[3];

                        syst.addSupplier(new Supplier(t, n, a, k));
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Exception is caught (LoadSuppliers)");
                }
            }

            bnLoadStock.Enabled = true;
            
        }
    }
}
