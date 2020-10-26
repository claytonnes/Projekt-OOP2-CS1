namespace CS1_Projekt_OOP2.Forms
{
    partial class FRMManageProducts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTN_updateProductInfo = new System.Windows.Forms.Button();
            this.TXT_editName = new System.Windows.Forms.TextBox();
            this.TXT_editPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXT_editStock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ProductGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTN_createNewCustomer = new System.Windows.Forms.Button();
            this.TXT_newName = new System.Windows.Forms.TextBox();
            this.TXT_newPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_newStock = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.filterBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BTN_updateProductInfo);
            this.groupBox2.Controls.Add(this.TXT_editName);
            this.groupBox2.Controls.Add(this.TXT_editPrice);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TXT_editStock);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(418, 738);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(387, 262);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select product from list to edit";
            // 
            // BTN_updateProductInfo
            // 
            this.BTN_updateProductInfo.Enabled = false;
            this.BTN_updateProductInfo.Location = new System.Drawing.Point(62, 183);
            this.BTN_updateProductInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_updateProductInfo.Name = "BTN_updateProductInfo";
            this.BTN_updateProductInfo.Size = new System.Drawing.Size(152, 48);
            this.BTN_updateProductInfo.TabIndex = 13;
            this.BTN_updateProductInfo.Text = "Update";
            this.BTN_updateProductInfo.UseVisualStyleBackColor = true;
            this.BTN_updateProductInfo.Click += new System.EventHandler(this.BTN_updateProductInfo_Click);
            // 
            // TXT_editName
            // 
            this.TXT_editName.Location = new System.Drawing.Point(122, 46);
            this.TXT_editName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXT_editName.Name = "TXT_editName";
            this.TXT_editName.Size = new System.Drawing.Size(230, 26);
            this.TXT_editName.TabIndex = 0;
            // 
            // TXT_editPrice
            // 
            this.TXT_editPrice.Location = new System.Drawing.Point(122, 86);
            this.TXT_editPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXT_editPrice.Name = "TXT_editPrice";
            this.TXT_editPrice.Size = new System.Drawing.Size(230, 26);
            this.TXT_editPrice.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Stock";
            // 
            // TXT_editStock
            // 
            this.TXT_editStock.Location = new System.Drawing.Point(122, 126);
            this.TXT_editStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXT_editStock.Name = "TXT_editStock";
            this.TXT_editStock.Size = new System.Drawing.Size(230, 26);
            this.TXT_editStock.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 97);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 57);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Name";
            // 
            // ProductGridView
            // 
            this.ProductGridView.AllowUserToAddRows = false;
            this.ProductGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ProductGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductGridView.EnableHeadersVisualStyles = false;
            this.ProductGridView.Location = new System.Drawing.Point(18, 26);
            this.ProductGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProductGridView.MultiSelect = false;
            this.ProductGridView.Name = "ProductGridView";
            this.ProductGridView.ReadOnly = true;
            this.ProductGridView.RowHeadersVisible = false;
            this.ProductGridView.RowHeadersWidth = 62;
            this.ProductGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductGridView.Size = new System.Drawing.Size(1154, 703);
            this.ProductGridView.TabIndex = 15;
            this.ProductGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductGridView_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTN_createNewCustomer);
            this.groupBox1.Controls.Add(this.TXT_newName);
            this.groupBox1.Controls.Add(this.TXT_newPrice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TXT_newStock);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 738);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(370, 262);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create new product";
            // 
            // BTN_createNewCustomer
            // 
            this.BTN_createNewCustomer.Location = new System.Drawing.Point(74, 183);
            this.BTN_createNewCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_createNewCustomer.Name = "BTN_createNewCustomer";
            this.BTN_createNewCustomer.Size = new System.Drawing.Size(220, 48);
            this.BTN_createNewCustomer.TabIndex = 6;
            this.BTN_createNewCustomer.Text = "Add new product";
            this.BTN_createNewCustomer.UseVisualStyleBackColor = true;
            this.BTN_createNewCustomer.Click += new System.EventHandler(this.BTN_createNewCustomer_Click);
            // 
            // TXT_newName
            // 
            this.TXT_newName.Location = new System.Drawing.Point(110, 46);
            this.TXT_newName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXT_newName.Name = "TXT_newName";
            this.TXT_newName.Size = new System.Drawing.Size(230, 26);
            this.TXT_newName.TabIndex = 0;
            // 
            // TXT_newPrice
            // 
            this.TXT_newPrice.Location = new System.Drawing.Point(110, 86);
            this.TXT_newPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXT_newPrice.Name = "TXT_newPrice";
            this.TXT_newPrice.Size = new System.Drawing.Size(230, 26);
            this.TXT_newPrice.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Stock";
            // 
            // TXT_newStock
            // 
            this.TXT_newStock.Location = new System.Drawing.Point(110, 126);
            this.TXT_newStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXT_newStock.Name = "TXT_newStock";
            this.TXT_newStock.Size = new System.Drawing.Size(230, 26);
            this.TXT_newStock.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.filterBox1);
            this.groupBox3.Location = new System.Drawing.Point(831, 740);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(340, 260);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filters";
            // 
            // filterBox1
            // 
            this.filterBox1.AutoSize = true;
            this.filterBox1.Location = new System.Drawing.Point(9, 29);
            this.filterBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.filterBox1.Name = "filterBox1";
            this.filterBox1.Size = new System.Drawing.Size(121, 24);
            this.filterBox1.TabIndex = 0;
            this.filterBox1.Text = "Out of stock";
            this.filterBox1.UseVisualStyleBackColor = true;
            this.filterBox1.CheckedChanged += new System.EventHandler(this.filterBox1_CheckedChanged);
            // 
            // FRMManageProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 1045);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ProductGridView);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FRMManageProducts";
            this.Text = "Product Management";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BTN_updateProductInfo;
        private System.Windows.Forms.TextBox TXT_editName;
        private System.Windows.Forms.TextBox TXT_editPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXT_editStock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView ProductGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTN_createNewCustomer;
        private System.Windows.Forms.TextBox TXT_newName;
        private System.Windows.Forms.TextBox TXT_newPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT_newStock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox filterBox1;
    }
}