namespace StockControlSystem
{
    partial class Computer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bnListAllStock = new System.Windows.Forms.Button();
            this.tbOrderItemKey = new System.Windows.Forms.TextBox();
            this.bnOrder = new System.Windows.Forms.Button();
            this.bnRestock = new System.Windows.Forms.Button();
            this.bnListOutstandingOrders = new System.Windows.Forms.Button();
            this.bnListStockBelowTH = new System.Windows.Forms.Button();
            this.bnExit = new System.Windows.Forms.Button();
            this.bnListAllSuppliers = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNumItemsToOrder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbRestockItemKey = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bnLoadStock = new System.Windows.Forms.Button();
            this.bnLoadSuppliers = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bnListAllStock
            // 
            this.bnListAllStock.Enabled = false;
            this.bnListAllStock.Location = new System.Drawing.Point(156, 61);
            this.bnListAllStock.Name = "bnListAllStock";
            this.bnListAllStock.Size = new System.Drawing.Size(100, 23);
            this.bnListAllStock.TabIndex = 0;
            this.bnListAllStock.Text = "List  All Stock";
            this.bnListAllStock.UseVisualStyleBackColor = true;
            this.bnListAllStock.Click += new System.EventHandler(this.bnListAllStock_Click);
            // 
            // tbOrderItemKey
            // 
            this.tbOrderItemKey.Location = new System.Drawing.Point(12, 24);
            this.tbOrderItemKey.Name = "tbOrderItemKey";
            this.tbOrderItemKey.Size = new System.Drawing.Size(100, 20);
            this.tbOrderItemKey.TabIndex = 1;
            // 
            // bnOrder
            // 
            this.bnOrder.Enabled = false;
            this.bnOrder.Location = new System.Drawing.Point(83, 50);
            this.bnOrder.Name = "bnOrder";
            this.bnOrder.Size = new System.Drawing.Size(75, 23);
            this.bnOrder.TabIndex = 2;
            this.bnOrder.Text = "Order";
            this.bnOrder.UseVisualStyleBackColor = true;
            this.bnOrder.Click += new System.EventHandler(this.bnOrder_Click);
            // 
            // bnRestock
            // 
            this.bnRestock.Enabled = false;
            this.bnRestock.Location = new System.Drawing.Point(128, 21);
            this.bnRestock.Name = "bnRestock";
            this.bnRestock.Size = new System.Drawing.Size(75, 23);
            this.bnRestock.TabIndex = 4;
            this.bnRestock.Text = "Restock";
            this.bnRestock.UseVisualStyleBackColor = true;
            this.bnRestock.Click += new System.EventHandler(this.bnRestock_Click);
            // 
            // bnListOutstandingOrders
            // 
            this.bnListOutstandingOrders.Enabled = false;
            this.bnListOutstandingOrders.Location = new System.Drawing.Point(126, 240);
            this.bnListOutstandingOrders.Name = "bnListOutstandingOrders";
            this.bnListOutstandingOrders.Size = new System.Drawing.Size(130, 23);
            this.bnListOutstandingOrders.TabIndex = 5;
            this.bnListOutstandingOrders.Text = "List Outstanding Orders";
            this.bnListOutstandingOrders.UseVisualStyleBackColor = true;
            this.bnListOutstandingOrders.Click += new System.EventHandler(this.bnListOutstandingOrders_Click);
            // 
            // bnListStockBelowTH
            // 
            this.bnListStockBelowTH.Enabled = false;
            this.bnListStockBelowTH.Location = new System.Drawing.Point(145, 101);
            this.bnListStockBelowTH.Name = "bnListStockBelowTH";
            this.bnListStockBelowTH.Size = new System.Drawing.Size(111, 23);
            this.bnListStockBelowTH.TabIndex = 6;
            this.bnListStockBelowTH.Text = "List  Scarce Stock";
            this.bnListStockBelowTH.UseVisualStyleBackColor = true;
            this.bnListStockBelowTH.Click += new System.EventHandler(this.bnListStockBelowTH_Click);
            // 
            // bnExit
            // 
            this.bnExit.Location = new System.Drawing.Point(100, 362);
            this.bnExit.Name = "bnExit";
            this.bnExit.Size = new System.Drawing.Size(75, 23);
            this.bnExit.TabIndex = 7;
            this.bnExit.Text = "Exit";
            this.bnExit.UseVisualStyleBackColor = true;
            this.bnExit.Click += new System.EventHandler(this.bnExit_Click);
            // 
            // bnListAllSuppliers
            // 
            this.bnListAllSuppliers.Enabled = false;
            this.bnListAllSuppliers.Location = new System.Drawing.Point(30, 61);
            this.bnListAllSuppliers.Name = "bnListAllSuppliers";
            this.bnListAllSuppliers.Size = new System.Drawing.Size(100, 23);
            this.bnListAllSuppliers.TabIndex = 8;
            this.bnListAllSuppliers.Text = "List All Suppliers";
            this.bnListAllSuppliers.UseVisualStyleBackColor = true;
            this.bnListAllSuppliers.Click += new System.EventHandler(this.bnListAllSuppliers_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Stock Item Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "# of Items To Order";
            // 
            // tbNumItemsToOrder
            // 
            this.tbNumItemsToOrder.Location = new System.Drawing.Point(129, 24);
            this.tbNumItemsToOrder.Name = "tbNumItemsToOrder";
            this.tbNumItemsToOrder.Size = new System.Drawing.Size(100, 20);
            this.tbNumItemsToOrder.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Stock Item Key";
            // 
            // tbRestockItemKey
            // 
            this.tbRestockItemKey.Location = new System.Drawing.Point(6, 23);
            this.tbRestockItemKey.Name = "tbRestockItemKey";
            this.tbRestockItemKey.Size = new System.Drawing.Size(100, 20);
            this.tbRestockItemKey.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbNumItemsToOrder);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bnOrder);
            this.groupBox1.Controls.Add(this.tbOrderItemKey);
            this.groupBox1.Location = new System.Drawing.Point(29, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 84);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbRestockItemKey);
            this.groupBox2.Controls.Add(this.bnRestock);
            this.groupBox2.Location = new System.Drawing.Point(34, 282);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 57);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // bnLoadStock
            // 
            this.bnLoadStock.Enabled = false;
            this.bnLoadStock.Location = new System.Drawing.Point(156, 22);
            this.bnLoadStock.Name = "bnLoadStock";
            this.bnLoadStock.Size = new System.Drawing.Size(100, 23);
            this.bnLoadStock.TabIndex = 17;
            this.bnLoadStock.Text = "Load Stock";
            this.bnLoadStock.UseVisualStyleBackColor = true;
            this.bnLoadStock.Click += new System.EventHandler(this.bnLoadStock_Click);
            // 
            // bnLoadSuppliers
            // 
            this.bnLoadSuppliers.Location = new System.Drawing.Point(29, 22);
            this.bnLoadSuppliers.Name = "bnLoadSuppliers";
            this.bnLoadSuppliers.Size = new System.Drawing.Size(100, 23);
            this.bnLoadSuppliers.TabIndex = 18;
            this.bnLoadSuppliers.Text = "Load Suppliers";
            this.bnLoadSuppliers.UseVisualStyleBackColor = true;
            this.bnLoadSuppliers.Click += new System.EventHandler(this.bnLoadSuppliers_Click);
            // 
            // Computer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 409);
            this.Controls.Add(this.bnLoadSuppliers);
            this.Controls.Add(this.bnLoadStock);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bnListAllSuppliers);
            this.Controls.Add(this.bnExit);
            this.Controls.Add(this.bnListStockBelowTH);
            this.Controls.Add(this.bnListOutstandingOrders);
            this.Controls.Add(this.bnListAllStock);
            this.Name = "Computer";
            this.Text = "System Computer";
            this.Load += new System.EventHandler(this.Computer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bnListAllStock;
        private System.Windows.Forms.TextBox tbOrderItemKey;
        private System.Windows.Forms.Button bnOrder;
        private System.Windows.Forms.Button bnRestock;
        private System.Windows.Forms.Button bnListOutstandingOrders;
        private System.Windows.Forms.Button bnListStockBelowTH;
        private System.Windows.Forms.Button bnExit;
        private System.Windows.Forms.Button bnListAllSuppliers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNumItemsToOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbRestockItemKey;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bnLoadStock;
        private System.Windows.Forms.Button bnLoadSuppliers;
    }
}

