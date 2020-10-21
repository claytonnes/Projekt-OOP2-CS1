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
            this.button2 = new System.Windows.Forms.Button();
            this.TXT_editName = new System.Windows.Forms.TextBox();
            this.TXT_editPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXT_editEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TXT_newName
            // 
            this.TXT_newName.Location = new System.Drawing.Point(73, 30);
            this.TXT_newName.Name = "TXT_newName";
            this.TXT_newName.Size = new System.Drawing.Size(155, 20);
            this.TXT_newName.TabIndex = 0;
            // 
            // TXT_newPhone
            // 
            this.TXT_newPhone.Location = new System.Drawing.Point(73, 56);
            this.TXT_newPhone.Name = "TXT_newPhone";
            this.TXT_newPhone.Size = new System.Drawing.Size(155, 20);
            this.TXT_newPhone.TabIndex = 1;
            // 
            // TXT_newEmail
            // 
            this.TXT_newEmail.Location = new System.Drawing.Point(73, 82);
            this.TXT_newEmail.Name = "TXT_newEmail";
            this.TXT_newEmail.Size = new System.Drawing.Size(155, 20);
            this.TXT_newEmail.TabIndex = 2;
            // 
            // BTN_createNewCustomer
            // 
            this.BTN_createNewCustomer.Location = new System.Drawing.Point(56, 124);
            this.BTN_createNewCustomer.Name = "BTN_createNewCustomer";
            this.BTN_createNewCustomer.Size = new System.Drawing.Size(147, 31);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 482);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 177);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create new customer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Phone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name";
            // 
            // CustomerGridView
            // 
            this.CustomerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerGridView.Location = new System.Drawing.Point(12, 12);
            this.CustomerGridView.MultiSelect = false;
            this.CustomerGridView.Name = "CustomerGridView";
            this.CustomerGridView.ReadOnly = true;
            this.CustomerGridView.RowHeadersVisible = false;
            this.CustomerGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomerGridView.Size = new System.Drawing.Size(613, 441);
            this.CustomerGridView.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BTN_updateCustomerInfo);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.TXT_editName);
            this.groupBox2.Controls.Add(this.TXT_editPhone);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TXT_editEmail);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(298, 482);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 177);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select from list to edit";
            // 
            // BTN_updateCustomerInfo
            // 
            this.BTN_updateCustomerInfo.Location = new System.Drawing.Point(41, 124);
            this.BTN_updateCustomerInfo.Name = "BTN_updateCustomerInfo";
            this.BTN_updateCustomerInfo.Size = new System.Drawing.Size(101, 31);
            this.BTN_updateCustomerInfo.TabIndex = 13;
            this.BTN_updateCustomerInfo.Text = "Update";
            this.BTN_updateCustomerInfo.UseVisualStyleBackColor = true;
            this.BTN_updateCustomerInfo.Click += new System.EventHandler(this.BTN_updateCustomerInfo_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCoral;
            this.button2.Location = new System.Drawing.Point(174, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 31);
            this.button2.TabIndex = 6;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TXT_editName
            // 
            this.TXT_editName.Location = new System.Drawing.Point(81, 30);
            this.TXT_editName.Name = "TXT_editName";
            this.TXT_editName.Size = new System.Drawing.Size(155, 20);
            this.TXT_editName.TabIndex = 0;
            // 
            // TXT_editPhone
            // 
            this.TXT_editPhone.Location = new System.Drawing.Point(81, 56);
            this.TXT_editPhone.Name = "TXT_editPhone";
            this.TXT_editPhone.Size = new System.Drawing.Size(155, 20);
            this.TXT_editPhone.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Email";
            // 
            // TXT_editEmail
            // 
            this.TXT_editEmail.Location = new System.Drawing.Point(81, 82);
            this.TXT_editEmail.Name = "TXT_editEmail";
            this.TXT_editEmail.Size = new System.Drawing.Size(155, 20);
            this.TXT_editEmail.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Name";
            // 
            // FRMManageCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 681);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.CustomerGridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "FRMManageCustomers";
            this.Text = "FRMManageCustomers";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TXT_editName;
        private System.Windows.Forms.TextBox TXT_editPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXT_editEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}