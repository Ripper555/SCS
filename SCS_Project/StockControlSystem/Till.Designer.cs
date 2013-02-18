namespace StockControlSystem
{
    partial class Till
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
            this.tbBarCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bnScan = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.bnTotal = new System.Windows.Forms.Button();
            this.bnBalance = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbBarCode
            // 
            this.tbBarCode.Location = new System.Drawing.Point(147, 57);
            this.tbBarCode.Name = "tbBarCode";
            this.tbBarCode.Size = new System.Drawing.Size(100, 20);
            this.tbBarCode.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bar Code Reader";
            // 
            // bnScan
            // 
            this.bnScan.Location = new System.Drawing.Point(147, 92);
            this.bnScan.Name = "bnScan";
            this.bnScan.Size = new System.Drawing.Size(75, 25);
            this.bnScan.TabIndex = 2;
            this.bnScan.Text = "Scan";
            this.bnScan.UseVisualStyleBackColor = true;
            this.bnScan.Click += new System.EventHandler(this.bnScan_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(30, 166);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 3;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(147, 166);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(100, 20);
            this.tbPrice.TabIndex = 4;
            // 
            // bnTotal
            // 
            this.bnTotal.Location = new System.Drawing.Point(147, 227);
            this.bnTotal.Name = "bnTotal";
            this.bnTotal.Size = new System.Drawing.Size(75, 23);
            this.bnTotal.TabIndex = 5;
            this.bnTotal.Text = "Total";
            this.bnTotal.UseVisualStyleBackColor = true;
            this.bnTotal.Click += new System.EventHandler(this.bnTotal_Click);
            // 
            // bnBalance
            // 
            this.bnBalance.Location = new System.Drawing.Point(30, 276);
            this.bnBalance.Name = "bnBalance";
            this.bnBalance.Size = new System.Drawing.Size(75, 23);
            this.bnBalance.TabIndex = 6;
            this.bnBalance.Text = "Balance";
            this.bnBalance.UseVisualStyleBackColor = true;
            this.bnBalance.Click += new System.EventHandler(this.bnBalance_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Price";
            // 
            // bnClear
            // 
            this.bnClear.Location = new System.Drawing.Point(147, 276);
            this.bnClear.Name = "bnClear";
            this.bnClear.Size = new System.Drawing.Size(75, 23);
            this.bnClear.TabIndex = 9;
            this.bnClear.Text = "Clear Trans.";
            this.bnClear.UseVisualStyleBackColor = true;
            this.bnClear.Click += new System.EventHandler(this.bnClear_Click);
            // 
            // Till
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 344);
            this.Controls.Add(this.bnClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bnBalance);
            this.Controls.Add(this.bnTotal);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.bnScan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbBarCode);
            this.Location = new System.Drawing.Point(600, 150);
            this.Name = "Till";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Till";
            this.Load += new System.EventHandler(this.Till_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbBarCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bnScan;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Button bnTotal;
        private System.Windows.Forms.Button bnBalance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bnClear;
    }
}