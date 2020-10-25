namespace CS1_Projekt_OOP2.Forms
{
    partial class FRMManageCustomers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TXT_newName = new System.Windows.Forms.TextBox();
            this.TXT_newPhone = new System.Windows.Forms.TextBox();
            this.TXT_newEmail = new System.Windows.Forms.TextBox();
            this.BTN_createNewCustomer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTN_updateCustomerInfo = new System.Windows.Forms.Button();
            this.TXT_editName = new System.Windows.Forms.TextBox();
            this.TXT_editPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXT_editEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ActiveOrdersGridView = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ArchivedOrdersGridView = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActiveOrdersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArchivedOrdersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TXT_newName
            // 
            this.TXT_newName.Location = new System.Drawing.Point(110, 46);
            this.TXT_newName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXT_newName.Name = "TXT_newName";
            this.TXT_newName.Size = new System.Drawing.Size(230, 26);
            this.TXT_newName.TabIndex = 0;
            // 
            // TXT_newPhone
            // 
            this.TXT_newPhone.Location = new System.Drawing.Point(110, 86);
            this.TXT_newPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXT_newPhone.Name = "TXT_newPhone";
            this.TXT_newPhone.Size = new System.Drawing.Size(230, 26);
            this.TXT_newPhone.TabIndex = 1;
            // 
            // TXT_newEmail
            // 
            this.TXT_newEmail.Location = new System.Drawing.Point(110, 126);
            this.TXT_newEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXT_newEmail.Name = "TXT_newEmail";
            this.TXT_newEmail.Size = new System.Drawing.Size(230, 26);
            this.TXT_newEmail.TabIndex = 2;
            // 
            // BTN_createNewCustomer
            // 
            this.BTN_createNewCustomer.Location = new System.Drawing.Point(84, 191);
            this.BTN_createNewCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_createNewCustomer.Name = "BTN_createNewCustomer";
            this.BTN_createNewCustomer.Size = new System.Drawing.Size(220, 48);
            this.BTN_createNewCustomer.TabIndex = 6;
            this.BTN_createNewCustomer.Text = "Create new customer";
            this.BTN_createNewCustomer.UseVisualStyleBackColor = true;
            this.BTN_createNewCustomer.Click += new System.EventHandler(this.BTN_createNewCustomer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTN_createNewCustomer);
            this.groupBox1.Controls.Add(this.TXT_newName);
            this.groupBox1.Controls.Add(this.TXT_newPhone);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TXT_newEmail);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(94, 742);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(370, 272);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create new customer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Email";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Phone";
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
            // CustomerGridView
            // 
            this.CustomerGridView.AllowUserToAddRows = false;
            this.CustomerGridView.AllowUserToDeleteRows = false;
            this.CustomerGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CustomerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerGridView.EnableHeadersVisualStyles = false;
            this.CustomerGridView.Location = new System.Drawing.Point(18, 62);
            this.CustomerGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CustomerGridView.MultiSelect = false;
            this.CustomerGridView.Name = "CustomerGridView";
            this.CustomerGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CustomerGridView.RowHeadersVisible = false;
            this.CustomerGridView.RowHeadersWidth = 62;
            this.CustomerGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomerGridView.Size = new System.Drawing.Size(1020, 635);
            this.CustomerGridView.TabIndex = 10;
            this.CustomerGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerGridView_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BTN_updateCustomerInfo);
            this.groupBox2.Controls.Add(this.TXT_editName);
            this.groupBox2.Controls.Add(this.TXT_editPhone);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TXT_editEmail);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(548, 742);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(435, 272);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edit selected customer";
            // 
            // BTN_updateCustomerInfo
            // 
            this.BTN_updateCustomerInfo.Enabled = false;
            this.BTN_updateCustomerInfo.Location = new System.Drawing.Point(122, 191);
            this.BTN_updateCustomerInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_updateCustomerInfo.Name = "BTN_updateCustomerInfo";
            this.BTN_updateCustomerInfo.Size = new System.Drawing.Size(152, 48);
            this.BTN_updateCustomerInfo.TabIndex = 13;
            this.BTN_updateCustomerInfo.Text = "Update";
            this.BTN_updateCustomerInfo.UseVisualStyleBackColor = true;
            this.BTN_updateCustomerInfo.Click += new System.EventHandler(this.BTN_updateCustomerInfo_Click_1);
            // 
            // TXT_editName
            // 
            this.TXT_editName.Location = new System.Drawing.Point(122, 46);
            this.TXT_editName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXT_editName.Name = "TXT_editName";
            this.TXT_editName.Size = new System.Drawing.Size(230, 26);
            this.TXT_editName.TabIndex = 0;
            // 
            // TXT_editPhone
            // 
            this.TXT_editPhone.Location = new System.Drawing.Point(122, 86);
            this.TXT_editPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXT_editPhone.Name = "TXT_editPhone";
            this.TXT_editPhone.Size = new System.Drawing.Size(230, 26);
            this.TXT_editPhone.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Email";
            // 
            // TXT_editEmail
            // 
            this.TXT_editEmail.Location = new System.Drawing.Point(122, 126);
            this.TXT_editEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXT_editEmail.Name = "TXT_editEmail";
            this.TXT_editEmail.Size = new System.Drawing.Size(230, 26);
            this.TXT_editEmail.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 97);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Phone";
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
            // ActiveOrdersGridView
            // 
            this.ActiveOrdersGridView.AllowUserToAddRows = false;
            this.ActiveOrdersGridView.AllowUserToDeleteRows = false;
            this.ActiveOrdersGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ActiveOrdersGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ActiveOrdersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActiveOrdersGridView.EnableHeadersVisualStyles = false;
            this.ActiveOrdersGridView.Location = new System.Drawing.Point(1082, 62);
            this.ActiveOrdersGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ActiveOrdersGridView.Name = "ActiveOrdersGridView";
            this.ActiveOrdersGridView.ReadOnly = true;
            this.ActiveOrdersGridView.RowHeadersVisible = false;
            this.ActiveOrdersGridView.RowHeadersWidth = 62;
            this.ActiveOrdersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ActiveOrdersGridView.Size = new System.Drawing.Size(974, 415);
            this.ActiveOrdersGridView.TabIndex = 14;
            this.ActiveOrdersGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ActiveOrdersGridView_CellClick);
            this.ActiveOrdersGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ActiveOrdersGridView_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1077, 37);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Active orders (click to view)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1077, 540);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(215, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Archived orders (click to view)";
            // 
            // ArchivedOrdersGridView
            // 
            this.ArchivedOrdersGridView.AllowUserToAddRows = false;
            this.ArchivedOrdersGridView.AllowUserToDeleteRows = false;
            this.ArchivedOrdersGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ArchivedOrdersGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ArchivedOrdersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ArchivedOrdersGridView.EnableHeadersVisualStyles = false;
            this.ArchivedOrdersGridView.Location = new System.Drawing.Point(1082, 565);
            this.ArchivedOrdersGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ArchivedOrdersGridView.Name = "ArchivedOrdersGridView";
            this.ArchivedOrdersGridView.ReadOnly = true;
            this.ArchivedOrdersGridView.RowHeadersVisible = false;
            this.ArchivedOrdersGridView.RowHeadersWidth = 62;
            this.ArchivedOrdersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ArchivedOrdersGridView.Size = new System.Drawing.Size(974, 415);
            this.ArchivedOrdersGridView.TabIndex = 18;
            this.ArchivedOrdersGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ArchivedOrdersGridView_CellClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 37);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "All customers";
            // 
            // FRMManageCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2110, 1048);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ArchivedOrdersGridView);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ActiveOrdersGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.CustomerGridView);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FRMManageCustomers";
            this.Text = "Customer Management";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActiveOrdersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArchivedOrdersGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXT_newName;
        private System.Windows.Forms.TextBox TXT_newPhone;
        private System.Windows.Forms.TextBox TXT_newEmail;
        private System.Windows.Forms.Button BTN_createNewCustomer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView CustomerGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BTN_updateCustomerInfo;
        private System.Windows.Forms.TextBox TXT_editName;
        private System.Windows.Forms.TextBox TXT_editPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXT_editEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView ActiveOrdersGridView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView ArchivedOrdersGridView;
        private System.Windows.Forms.Label label9;
    }
}