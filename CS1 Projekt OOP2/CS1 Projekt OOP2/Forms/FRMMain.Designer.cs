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
            this.PendingOrdersGridView = new System.Windows.Forms.DataGridView();
            this.BTNProducts = new System.Windows.Forms.Button();
            this.BTN_ProcessOrders = new System.Windows.Forms.Button();
            this.BTNNewOrder = new System.Windows.Forms.Button();
            this.BTN_OpenFRMCustomers = new System.Windows.Forms.Button();
            this.DispatchedOrdersGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PendingOrdersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DispatchedOrdersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PendingOrdersGridView
            // 
            this.PendingOrdersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PendingOrdersGridView.Location = new System.Drawing.Point(51, 111);
            this.PendingOrdersGridView.Margin = new System.Windows.Forms.Padding(2);
            this.PendingOrdersGridView.MultiSelect = false;
            this.PendingOrdersGridView.Name = "PendingOrdersGridView";
            this.PendingOrdersGridView.ReadOnly = true;
            this.PendingOrdersGridView.RowHeadersWidth = 62;
            this.PendingOrdersGridView.RowTemplate.Height = 28;
            this.PendingOrdersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PendingOrdersGridView.Size = new System.Drawing.Size(698, 253);
            this.PendingOrdersGridView.TabIndex = 0;
            // 
            // BTNProducts
            // 
            this.BTNProducts.Location = new System.Drawing.Point(638, 29);
            this.BTNProducts.Margin = new System.Windows.Forms.Padding(2);
            this.BTNProducts.Name = "BTNProducts";
            this.BTNProducts.Size = new System.Drawing.Size(120, 40);
            this.BTNProducts.TabIndex = 1;
            this.BTNProducts.Text = "Manage Products";
            this.BTNProducts.UseVisualStyleBackColor = true;
            this.BTNProducts.Click += new System.EventHandler(this.BTNProducts_Click);
            // 
            // BTN_ProcessOrders
            // 
            this.BTN_ProcessOrders.Location = new System.Drawing.Point(51, 28);
            this.BTN_ProcessOrders.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_ProcessOrders.Name = "BTN_ProcessOrders";
            this.BTN_ProcessOrders.Size = new System.Drawing.Size(122, 43);
            this.BTN_ProcessOrders.TabIndex = 4;
            this.BTN_ProcessOrders.Text = "Process Orders";
            this.BTN_ProcessOrders.UseVisualStyleBackColor = true;
            this.BTN_ProcessOrders.Click += new System.EventHandler(this.BTN_ProcessOrders_Click);
            // 
            // BTNNewOrder
            // 
            this.BTNNewOrder.Location = new System.Drawing.Point(388, 29);
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
            this.BTN_OpenFRMCustomers.Location = new System.Drawing.Point(513, 29);
            this.BTN_OpenFRMCustomers.Name = "BTN_OpenFRMCustomers";
            this.BTN_OpenFRMCustomers.Size = new System.Drawing.Size(120, 40);
            this.BTN_OpenFRMCustomers.TabIndex = 6;
            this.BTN_OpenFRMCustomers.Text = "Manage Customers";
            this.BTN_OpenFRMCustomers.UseVisualStyleBackColor = true;
            this.BTN_OpenFRMCustomers.Click += new System.EventHandler(this.BTN_OpenFRMCustomers_Click_1);
            // 
            // DispatchedOrdersGridView
            // 
            this.DispatchedOrdersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DispatchedOrdersGridView.Location = new System.Drawing.Point(51, 402);
            this.DispatchedOrdersGridView.Margin = new System.Windows.Forms.Padding(2);
            this.DispatchedOrdersGridView.MultiSelect = false;
            this.DispatchedOrdersGridView.Name = "DispatchedOrdersGridView";
            this.DispatchedOrdersGridView.ReadOnly = true;
            this.DispatchedOrdersGridView.RowHeadersWidth = 62;
            this.DispatchedOrdersGridView.RowTemplate.Height = 28;
            this.DispatchedOrdersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DispatchedOrdersGridView.Size = new System.Drawing.Size(698, 253);
            this.DispatchedOrdersGridView.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Pending Orders";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Dispatched Orders";
            // 
            // FRMMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 691);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DispatchedOrdersGridView);
            this.Controls.Add(this.BTN_OpenFRMCustomers);
            this.Controls.Add(this.BTNNewOrder);
            this.Controls.Add(this.BTN_ProcessOrders);
            this.Controls.Add(this.BTNProducts);
            this.Controls.Add(this.PendingOrdersGridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FRMMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PendingOrdersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DispatchedOrdersGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PendingOrdersGridView;
        private System.Windows.Forms.Button BTNProducts;
        private System.Windows.Forms.Button BTN_ProcessOrders;
        private System.Windows.Forms.Button BTNNewOrder;
        private System.Windows.Forms.Button BTN_OpenFRMCustomers;
        private System.Windows.Forms.DataGridView DispatchedOrdersGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

