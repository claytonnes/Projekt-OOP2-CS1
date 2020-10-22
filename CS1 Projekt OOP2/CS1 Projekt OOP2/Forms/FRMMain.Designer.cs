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
            this.OrdersGridView = new System.Windows.Forms.DataGridView();
            this.BTNProducts = new System.Windows.Forms.Button();
            this.BTNChange = new System.Windows.Forms.Button();
            this.BTNZeroStock = new System.Windows.Forms.Button();
            this.BTNClosestDate = new System.Windows.Forms.Button();
            this.BTNNewOrder = new System.Windows.Forms.Button();
            this.BTN_OpenFRMCustomers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // OrdersGridView
            // 
            this.OrdersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersGridView.Location = new System.Drawing.Point(36, 86);
            this.OrdersGridView.Margin = new System.Windows.Forms.Padding(2);
            this.OrdersGridView.Name = "OrdersGridView";
            this.OrdersGridView.RowHeadersWidth = 62;
            this.OrdersGridView.RowTemplate.Height = 28;
            this.OrdersGridView.Size = new System.Drawing.Size(698, 253);
            this.OrdersGridView.TabIndex = 0;
            // 
            // BTNProducts
            // 
            this.BTNProducts.Location = new System.Drawing.Point(453, 29);
            this.BTNProducts.Margin = new System.Windows.Forms.Padding(2);
            this.BTNProducts.Name = "BTNProducts";
            this.BTNProducts.Size = new System.Drawing.Size(120, 40);
            this.BTNProducts.TabIndex = 1;
            this.BTNProducts.Text = "Manage Products";
            this.BTNProducts.UseVisualStyleBackColor = true;
            this.BTNProducts.Click += new System.EventHandler(this.BTNProducts_Click);
            // 
            // BTNChange
            // 
            this.BTNChange.Location = new System.Drawing.Point(157, 372);
            this.BTNChange.Margin = new System.Windows.Forms.Padding(2);
            this.BTNChange.Name = "BTNChange";
            this.BTNChange.Size = new System.Drawing.Size(122, 43);
            this.BTNChange.TabIndex = 2;
            this.BTNChange.Text = "Change Information";
            this.BTNChange.UseVisualStyleBackColor = true;
            // 
            // BTNZeroStock
            // 
            this.BTNZeroStock.Location = new System.Drawing.Point(338, 372);
            this.BTNZeroStock.Margin = new System.Windows.Forms.Padding(2);
            this.BTNZeroStock.Name = "BTNZeroStock";
            this.BTNZeroStock.Size = new System.Drawing.Size(122, 43);
            this.BTNZeroStock.TabIndex = 3;
            this.BTNZeroStock.Text = "Out of Products";
            this.BTNZeroStock.UseVisualStyleBackColor = true;
            // 
            // BTNClosestDate
            // 
            this.BTNClosestDate.Location = new System.Drawing.Point(514, 372);
            this.BTNClosestDate.Margin = new System.Windows.Forms.Padding(2);
            this.BTNClosestDate.Name = "BTNClosestDate";
            this.BTNClosestDate.Size = new System.Drawing.Size(122, 43);
            this.BTNClosestDate.TabIndex = 4;
            this.BTNClosestDate.Text = "Closest Date in stock";
            this.BTNClosestDate.UseVisualStyleBackColor = true;
            // 
            // BTNNewOrder
            // 
            this.BTNNewOrder.Location = new System.Drawing.Point(178, 29);
            this.BTNNewOrder.Margin = new System.Windows.Forms.Padding(2);
            this.BTNNewOrder.Name = "BTNNewOrder";
            this.BTNNewOrder.Size = new System.Drawing.Size(120, 40);
            this.BTNNewOrder.TabIndex = 5;
            this.BTNNewOrder.Text = "Add New Order";
            this.BTNNewOrder.UseVisualStyleBackColor = true;
            this.BTNNewOrder.Click += new System.EventHandler(this.BTNNewOrder_Click);
            // 
            // BTN_OpenFRMCustomers
            // 
            this.BTN_OpenFRMCustomers.Location = new System.Drawing.Point(314, 29);
            this.BTN_OpenFRMCustomers.Name = "BTN_OpenFRMCustomers";
            this.BTN_OpenFRMCustomers.Size = new System.Drawing.Size(120, 40);
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
            this.Controls.Add(this.BTNProducts);
            this.Controls.Add(this.OrdersGridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FRMMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FRMMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView OrdersGridView;
        private System.Windows.Forms.Button BTNProducts;
        private System.Windows.Forms.Button BTNChange;
        private System.Windows.Forms.Button BTNZeroStock;
        private System.Windows.Forms.Button BTNClosestDate;
        private System.Windows.Forms.Button BTNNewOrder;
        private System.Windows.Forms.Button BTN_OpenFRMCustomers;
    }
}

