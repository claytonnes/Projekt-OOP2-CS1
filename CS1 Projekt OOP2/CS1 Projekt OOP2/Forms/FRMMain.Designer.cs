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
            this.BTN_ShowPending = new System.Windows.Forms.Button();
            this.BTN_ProcessOrders = new System.Windows.Forms.Button();
            this.BTNNewOrder = new System.Windows.Forms.Button();
            this.BTN_OpenFRMCustomers = new System.Windows.Forms.Button();
            this.LBL_Filter = new System.Windows.Forms.Label();
            this.BTN_ShowDispatched = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // OrdersGridView
            // 
            this.OrdersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersGridView.Location = new System.Drawing.Point(36, 86);
            this.OrdersGridView.Margin = new System.Windows.Forms.Padding(2);
            this.OrdersGridView.MultiSelect = false;
            this.OrdersGridView.Name = "OrdersGridView";
            this.OrdersGridView.ReadOnly = true;
            this.OrdersGridView.RowHeadersWidth = 62;
            this.OrdersGridView.RowTemplate.Height = 28;
            this.OrdersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
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
            // BTN_ShowPending
            // 
            this.BTN_ShowPending.Location = new System.Drawing.Point(36, 367);
            this.BTN_ShowPending.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_ShowPending.Name = "BTN_ShowPending";
            this.BTN_ShowPending.Size = new System.Drawing.Size(122, 22);
            this.BTN_ShowPending.TabIndex = 2;
            this.BTN_ShowPending.Text = "Pending Orders";
            this.BTN_ShowPending.UseVisualStyleBackColor = true;
            this.BTN_ShowPending.Click += new System.EventHandler(this.BTN_ShowPending_Click);
            // 
            // BTN_ProcessOrders
            // 
            this.BTN_ProcessOrders.Location = new System.Drawing.Point(314, 357);
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
            // LBL_Filter
            // 
            this.LBL_Filter.AutoSize = true;
            this.LBL_Filter.Location = new System.Drawing.Point(33, 352);
            this.LBL_Filter.Name = "LBL_Filter";
            this.LBL_Filter.Size = new System.Drawing.Size(63, 13);
            this.LBL_Filter.TabIndex = 7;
            this.LBL_Filter.Text = "Filter Orders";
            // 
            // BTN_ShowDispatched
            // 
            this.BTN_ShowDispatched.Location = new System.Drawing.Point(36, 393);
            this.BTN_ShowDispatched.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_ShowDispatched.Name = "BTN_ShowDispatched";
            this.BTN_ShowDispatched.Size = new System.Drawing.Size(122, 22);
            this.BTN_ShowDispatched.TabIndex = 8;
            this.BTN_ShowDispatched.Text = "Dispatched Orders";
            this.BTN_ShowDispatched.UseVisualStyleBackColor = true;
            this.BTN_ShowDispatched.Click += new System.EventHandler(this.BTN_ShowDispatched_Click);
            // 
            // FRMMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 459);
            this.Controls.Add(this.BTN_ShowDispatched);
            this.Controls.Add(this.LBL_Filter);
            this.Controls.Add(this.BTN_OpenFRMCustomers);
            this.Controls.Add(this.BTNNewOrder);
            this.Controls.Add(this.BTN_ProcessOrders);
            this.Controls.Add(this.BTN_ShowPending);
            this.Controls.Add(this.BTNProducts);
            this.Controls.Add(this.OrdersGridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FRMMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FRMMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView OrdersGridView;
        private System.Windows.Forms.Button BTNProducts;
        private System.Windows.Forms.Button BTN_ShowPending;
        private System.Windows.Forms.Button BTN_ProcessOrders;
        private System.Windows.Forms.Button BTNNewOrder;
        private System.Windows.Forms.Button BTN_OpenFRMCustomers;
        private System.Windows.Forms.Label LBL_Filter;
        private System.Windows.Forms.Button BTN_ShowDispatched;
    }
}

