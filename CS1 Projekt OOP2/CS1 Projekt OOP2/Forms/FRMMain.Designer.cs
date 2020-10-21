namespace CS1_Projekt_OOP2
{
    partial class FRMMain
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BTNAdd = new System.Windows.Forms.Button();
            this.BTNChange = new System.Windows.Forms.Button();
            this.BTNZeroStock = new System.Windows.Forms.Button();
            this.BTNClosestDate = new System.Windows.Forms.Button();
            this.BTNNewOrder = new System.Windows.Forms.Button();
            this.BTN_OpenFRMCustomers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(46, 55);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(523, 235);
            this.dataGridView1.TabIndex = 0;
            // 
            // BTNAdd
            // 
            this.BTNAdd.Location = new System.Drawing.Point(46, 341);
            this.BTNAdd.Margin = new System.Windows.Forms.Padding(2);
            this.BTNAdd.Name = "BTNAdd";
            this.BTNAdd.Size = new System.Drawing.Size(122, 43);
            this.BTNAdd.TabIndex = 1;
            this.BTNAdd.Text = "Add Product";
            this.BTNAdd.UseVisualStyleBackColor = true;
            // 
            // BTNChange
            // 
            this.BTNChange.Location = new System.Drawing.Point(181, 341);
            this.BTNChange.Margin = new System.Windows.Forms.Padding(2);
            this.BTNChange.Name = "BTNChange";
            this.BTNChange.Size = new System.Drawing.Size(122, 43);
            this.BTNChange.TabIndex = 2;
            this.BTNChange.Text = "Change Information";
            this.BTNChange.UseVisualStyleBackColor = true;
            // 
            // BTNZeroStock
            // 
            this.BTNZeroStock.Location = new System.Drawing.Point(314, 341);
            this.BTNZeroStock.Margin = new System.Windows.Forms.Padding(2);
            this.BTNZeroStock.Name = "BTNZeroStock";
            this.BTNZeroStock.Size = new System.Drawing.Size(122, 43);
            this.BTNZeroStock.TabIndex = 3;
            this.BTNZeroStock.Text = "Out of Products";
            this.BTNZeroStock.UseVisualStyleBackColor = true;
            // 
            // BTNClosestDate
            // 
            this.BTNClosestDate.Location = new System.Drawing.Point(447, 341);
            this.BTNClosestDate.Margin = new System.Windows.Forms.Padding(2);
            this.BTNClosestDate.Name = "BTNClosestDate";
            this.BTNClosestDate.Size = new System.Drawing.Size(122, 43);
            this.BTNClosestDate.TabIndex = 4;
            this.BTNClosestDate.Text = "Closest Date in stock";
            this.BTNClosestDate.UseVisualStyleBackColor = true;
            // 
            // BTNNewOrder
            // 
            this.BTNNewOrder.Location = new System.Drawing.Point(595, 55);
            this.BTNNewOrder.Margin = new System.Windows.Forms.Padding(2);
            this.BTNNewOrder.Name = "BTNNewOrder";
            this.BTNNewOrder.Size = new System.Drawing.Size(122, 43);
            this.BTNNewOrder.TabIndex = 5;
            this.BTNNewOrder.Text = "New Order";
            this.BTNNewOrder.UseVisualStyleBackColor = true;
            this.BTNNewOrder.Click += new System.EventHandler(this.BTNNewOrder_Click);
            // 
            // BTN_OpenFRMCustomers
            // 
            this.BTN_OpenFRMCustomers.Location = new System.Drawing.Point(595, 141);
            this.BTN_OpenFRMCustomers.Name = "BTN_OpenFRMCustomers";
            this.BTN_OpenFRMCustomers.Size = new System.Drawing.Size(122, 52);
            this.BTN_OpenFRMCustomers.TabIndex = 6;
            this.BTN_OpenFRMCustomers.Text = "Manage Customers";
            this.BTN_OpenFRMCustomers.UseVisualStyleBackColor = true;
            this.BTN_OpenFRMCustomers.Click += new System.EventHandler(this.BTN_OpenFRMCustomers_Click_1);
            // 
            // FRMMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 459);
            this.Controls.Add(this.BTN_OpenFRMCustomers);
            this.Controls.Add(this.BTNNewOrder);
            this.Controls.Add(this.BTNClosestDate);
            this.Controls.Add(this.BTNZeroStock);
            this.Controls.Add(this.BTNChange);
            this.Controls.Add(this.BTNAdd);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FRMMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FRMMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BTNAdd;
        private System.Windows.Forms.Button BTNChange;
        private System.Windows.Forms.Button BTNZeroStock;
        private System.Windows.Forms.Button BTNClosestDate;
        private System.Windows.Forms.Button BTNNewOrder;
        private System.Windows.Forms.Button BTN_OpenFRMCustomers;
    }
}

