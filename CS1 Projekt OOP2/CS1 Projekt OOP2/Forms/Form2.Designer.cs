namespace CS1_Projekt_OOP2
{
    partial class Form2
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
            this.BTNDispatch = new System.Windows.Forms.Button();
            this.BTNDpendingOrders = new System.Windows.Forms.Button();
            this.BTNDispatchedOrders = new System.Windows.Forms.Button();
            this.BTNCustomers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(71, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(637, 381);
            this.dataGridView1.TabIndex = 0;
            // 
            // BTNDispatch
            // 
            this.BTNDispatch.Location = new System.Drawing.Point(71, 527);
            this.BTNDispatch.Name = "BTNDispatch";
            this.BTNDispatch.Size = new System.Drawing.Size(169, 61);
            this.BTNDispatch.TabIndex = 1;
            this.BTNDispatch.Text = "Dispach Order";
            this.BTNDispatch.UseVisualStyleBackColor = true;
            // 
            // BTNDpendingOrders
            // 
            this.BTNDpendingOrders.Location = new System.Drawing.Point(756, 200);
            this.BTNDpendingOrders.Name = "BTNDpendingOrders";
            this.BTNDpendingOrders.Size = new System.Drawing.Size(169, 61);
            this.BTNDpendingOrders.TabIndex = 3;
            this.BTNDpendingOrders.Text = "View Pending Orders";
            this.BTNDpendingOrders.UseVisualStyleBackColor = true;
            this.BTNDpendingOrders.Click += new System.EventHandler(this.BTNDpendingOrders_Click);
            // 
            // BTNDispatchedOrders
            // 
            this.BTNDispatchedOrders.Location = new System.Drawing.Point(756, 100);
            this.BTNDispatchedOrders.Name = "BTNDispatchedOrders";
            this.BTNDispatchedOrders.Size = new System.Drawing.Size(169, 61);
            this.BTNDispatchedOrders.TabIndex = 4;
            this.BTNDispatchedOrders.Text = "View Dispatched Orders";
            this.BTNDispatchedOrders.UseVisualStyleBackColor = true;
            this.BTNDispatchedOrders.Click += new System.EventHandler(this.BTNDispatchedOrders_Click);
            // 
            // BTNCustomers
            // 
            this.BTNCustomers.Location = new System.Drawing.Point(756, 305);
            this.BTNCustomers.Name = "BTNCustomers";
            this.BTNCustomers.Size = new System.Drawing.Size(169, 61);
            this.BTNCustomers.TabIndex = 5;
            this.BTNCustomers.Text = "Customers Information";
            this.BTNCustomers.UseVisualStyleBackColor = true;
            this.BTNCustomers.Click += new System.EventHandler(this.BTNCustomers_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 656);
            this.Controls.Add(this.BTNCustomers);
            this.Controls.Add(this.BTNDispatchedOrders);
            this.Controls.Add(this.BTNDpendingOrders);
            this.Controls.Add(this.BTNDispatch);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BTNDispatch;
        private System.Windows.Forms.Button BTNDpendingOrders;
        private System.Windows.Forms.Button BTNDispatchedOrders;
        private System.Windows.Forms.Button BTNCustomers;
    }
}