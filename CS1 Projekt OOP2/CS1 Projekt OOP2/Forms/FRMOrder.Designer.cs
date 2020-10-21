namespace CS1_Projekt_OOP2
{
    partial class FRMOrder
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
            this.orderGridView = new System.Windows.Forms.DataGridView();
            this.BTNDispatch = new System.Windows.Forms.Button();
            this.BTNDpendingOrders = new System.Windows.Forms.Button();
            this.BTNDispatchedOrders = new System.Windows.Forms.Button();
            this.BTNCustomers = new System.Windows.Forms.Button();
            this.BTNClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // orderGridView
            // 
            this.orderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderGridView.Location = new System.Drawing.Point(47, 65);
            this.orderGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.orderGridView.Name = "orderGridView";
            this.orderGridView.RowHeadersWidth = 62;
            this.orderGridView.RowTemplate.Height = 28;
            this.orderGridView.Size = new System.Drawing.Size(425, 248);
            this.orderGridView.TabIndex = 0;
            // 
            // BTNDispatch
            // 
            this.BTNDispatch.Location = new System.Drawing.Point(47, 343);
            this.BTNDispatch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNDispatch.Name = "BTNDispatch";
            this.BTNDispatch.Size = new System.Drawing.Size(113, 40);
            this.BTNDispatch.TabIndex = 1;
            this.BTNDispatch.Text = "Dispach Order";
            this.BTNDispatch.UseVisualStyleBackColor = true;
            // 
            // BTNDpendingOrders
            // 
            this.BTNDpendingOrders.Location = new System.Drawing.Point(504, 130);
            this.BTNDpendingOrders.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNDpendingOrders.Name = "BTNDpendingOrders";
            this.BTNDpendingOrders.Size = new System.Drawing.Size(113, 40);
            this.BTNDpendingOrders.TabIndex = 3;
            this.BTNDpendingOrders.Text = "View Pending Orders";
            this.BTNDpendingOrders.UseVisualStyleBackColor = true;
            this.BTNDpendingOrders.Click += new System.EventHandler(this.BTNDpendingOrders_Click);
            // 
            // BTNDispatchedOrders
            // 
            this.BTNDispatchedOrders.Location = new System.Drawing.Point(504, 65);
            this.BTNDispatchedOrders.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNDispatchedOrders.Name = "BTNDispatchedOrders";
            this.BTNDispatchedOrders.Size = new System.Drawing.Size(113, 40);
            this.BTNDispatchedOrders.TabIndex = 4;
            this.BTNDispatchedOrders.Text = "View Dispatched Orders";
            this.BTNDispatchedOrders.UseVisualStyleBackColor = true;
            this.BTNDispatchedOrders.Click += new System.EventHandler(this.BTNDispatchedOrders_Click);
            // 
            // BTNCustomers
            // 
            this.BTNCustomers.Location = new System.Drawing.Point(504, 198);
            this.BTNCustomers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNCustomers.Name = "BTNCustomers";
            this.BTNCustomers.Size = new System.Drawing.Size(113, 40);
            this.BTNCustomers.TabIndex = 5;
            this.BTNCustomers.Text = "Customers Information";
            this.BTNCustomers.UseVisualStyleBackColor = true;
            this.BTNCustomers.Click += new System.EventHandler(this.BTNCustomers_Click);
            // 
            // BTNClose
            // 
            this.BTNClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTNClose.Location = new System.Drawing.Point(677, 391);
            this.BTNClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNClose.Name = "BTNClose";
            this.BTNClose.Size = new System.Drawing.Size(62, 19);
            this.BTNClose.TabIndex = 6;
            this.BTNClose.Text = "Close";
            this.BTNClose.UseVisualStyleBackColor = true;
            // 
            // FRMOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 426);
            this.Controls.Add(this.BTNClose);
            this.Controls.Add(this.BTNCustomers);
            this.Controls.Add(this.BTNDispatchedOrders);
            this.Controls.Add(this.BTNDpendingOrders);
            this.Controls.Add(this.BTNDispatch);
            this.Controls.Add(this.orderGridView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FRMOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FRMOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView orderGridView;
        private System.Windows.Forms.Button BTNDispatch;
        private System.Windows.Forms.Button BTNDpendingOrders;
        private System.Windows.Forms.Button BTNDispatchedOrders;
        private System.Windows.Forms.Button BTNCustomers;
        private System.Windows.Forms.Button BTNClose;
    }
}