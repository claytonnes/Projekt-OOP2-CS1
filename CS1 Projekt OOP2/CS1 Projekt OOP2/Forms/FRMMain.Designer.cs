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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PendingOrdersGridView = new System.Windows.Forms.DataGridView();
            this.BTNProducts = new System.Windows.Forms.Button();
            this.BTNNewOrder = new System.Windows.Forms.Button();
            this.BTN_OpenFRMCustomers = new System.Windows.Forms.Button();
            this.DispatchedOrdersGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTNProcessOrders = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PendingOrdersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DispatchedOrdersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PendingOrdersGridView
            // 
            this.PendingOrdersGridView.AllowUserToAddRows = false;
            this.PendingOrdersGridView.AllowUserToDeleteRows = false;
            this.PendingOrdersGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PendingOrdersGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.PendingOrdersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PendingOrdersGridView.EnableHeadersVisualStyles = false;
            this.PendingOrdersGridView.Location = new System.Drawing.Point(11, 26);
            this.PendingOrdersGridView.Margin = new System.Windows.Forms.Padding(2);
            this.PendingOrdersGridView.MultiSelect = false;
            this.PendingOrdersGridView.Name = "PendingOrdersGridView";
            this.PendingOrdersGridView.ReadOnly = true;
            this.PendingOrdersGridView.RowHeadersVisible = false;
            this.PendingOrdersGridView.RowHeadersWidth = 62;
            this.PendingOrdersGridView.RowTemplate.Height = 28;
            this.PendingOrdersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PendingOrdersGridView.Size = new System.Drawing.Size(698, 253);
            this.PendingOrdersGridView.TabIndex = 0;
            this.PendingOrdersGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PendingOrdersGridView_CellClick);
            // 
            // BTNProducts
            // 
            this.BTNProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNProducts.Location = new System.Drawing.Point(790, 106);
            this.BTNProducts.Margin = new System.Windows.Forms.Padding(2);
            this.BTNProducts.Name = "BTNProducts";
            this.BTNProducts.Size = new System.Drawing.Size(128, 50);
            this.BTNProducts.TabIndex = 1;
            this.BTNProducts.Text = "Manage Products";
            this.BTNProducts.UseVisualStyleBackColor = true;
            this.BTNProducts.Click += new System.EventHandler(this.BTNProducts_Click);
            // 
            // BTNNewOrder
            // 
            this.BTNNewOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNNewOrder.Location = new System.Drawing.Point(790, 181);
            this.BTNNewOrder.Margin = new System.Windows.Forms.Padding(2);
            this.BTNNewOrder.Name = "BTNNewOrder";
            this.BTNNewOrder.Size = new System.Drawing.Size(128, 50);
            this.BTNNewOrder.TabIndex = 5;
            this.BTNNewOrder.Text = "Add New Order";
            this.BTNNewOrder.UseVisualStyleBackColor = true;
            this.BTNNewOrder.Click += new System.EventHandler(this.BTNNewOrder_Click);
            // 
            // BTN_OpenFRMCustomers
            // 
            this.BTN_OpenFRMCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_OpenFRMCustomers.Location = new System.Drawing.Point(790, 26);
            this.BTN_OpenFRMCustomers.Name = "BTN_OpenFRMCustomers";
            this.BTN_OpenFRMCustomers.Size = new System.Drawing.Size(128, 50);
            this.BTN_OpenFRMCustomers.TabIndex = 6;
            this.BTN_OpenFRMCustomers.Text = "Manage Customers";
            this.BTN_OpenFRMCustomers.UseVisualStyleBackColor = true;
            this.BTN_OpenFRMCustomers.Click += new System.EventHandler(this.BTN_OpenFRMCustomers_Click_1);
            // 
            // DispatchedOrdersGridView
            // 
            this.DispatchedOrdersGridView.AllowUserToAddRows = false;
            this.DispatchedOrdersGridView.AllowUserToDeleteRows = false;
            this.DispatchedOrdersGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DispatchedOrdersGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DispatchedOrdersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DispatchedOrdersGridView.EnableHeadersVisualStyles = false;
            this.DispatchedOrdersGridView.Location = new System.Drawing.Point(11, 321);
            this.DispatchedOrdersGridView.Margin = new System.Windows.Forms.Padding(2);
            this.DispatchedOrdersGridView.MultiSelect = false;
            this.DispatchedOrdersGridView.Name = "DispatchedOrdersGridView";
            this.DispatchedOrdersGridView.ReadOnly = true;
            this.DispatchedOrdersGridView.RowHeadersVisible = false;
            this.DispatchedOrdersGridView.RowHeadersWidth = 62;
            this.DispatchedOrdersGridView.RowTemplate.Height = 28;
            this.DispatchedOrdersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DispatchedOrdersGridView.Size = new System.Drawing.Size(698, 253);
            this.DispatchedOrdersGridView.TabIndex = 9;
            this.DispatchedOrdersGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DispatchedOrdersGridView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Pending Orders (click to view)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Dispatched Orders (click to view)";
            // 
            // BTNProcessOrders
            // 
            this.BTNProcessOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNProcessOrders.Location = new System.Drawing.Point(799, 524);
            this.BTNProcessOrders.Margin = new System.Windows.Forms.Padding(2);
            this.BTNProcessOrders.Name = "BTNProcessOrders";
            this.BTNProcessOrders.Size = new System.Drawing.Size(128, 50);
            this.BTNProcessOrders.TabIndex = 12;
            this.BTNProcessOrders.Text = "Process Orders";
            this.BTNProcessOrders.UseVisualStyleBackColor = true;
            this.BTNProcessOrders.Click += new System.EventHandler(this.BTNProcessOrders_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CS1_Projekt_OOP2.Properties.Resources.cogwheel;
            this.pictureBox4.Location = new System.Drawing.Point(736, 524);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CS1_Projekt_OOP2.Properties.Resources.plus;
            this.pictureBox3.Location = new System.Drawing.Point(743, 190);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CS1_Projekt_OOP2.Properties.Resources.packages;
            this.pictureBox2.Location = new System.Drawing.Point(738, 111);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CS1_Projekt_OOP2.Properties.Resources.teamwork;
            this.pictureBox1.Location = new System.Drawing.Point(739, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label3.Location = new System.Drawing.Point(465, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "*Refunds occur upon processing orders";
            // 
            // FRMMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 601);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTNProcessOrders);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DispatchedOrdersGridView);
            this.Controls.Add(this.BTN_OpenFRMCustomers);
            this.Controls.Add(this.BTNNewOrder);
            this.Controls.Add(this.BTNProducts);
            this.Controls.Add(this.PendingOrdersGridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FRMMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Warehouse Control Panel";
            ((System.ComponentModel.ISupportInitialize)(this.PendingOrdersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DispatchedOrdersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PendingOrdersGridView;
        private System.Windows.Forms.Button BTNProducts;
        private System.Windows.Forms.Button BTNNewOrder;
        private System.Windows.Forms.Button BTN_OpenFRMCustomers;
        private System.Windows.Forms.DataGridView DispatchedOrdersGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTNProcessOrders;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}

