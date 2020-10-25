namespace CS1_Projekt_OOP2.Forms
{
    partial class FRMCreateNewOrder
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
            this.LST_customers = new System.Windows.Forms.ListBox();
            this.LST_products = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTN_manageCustomers = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTN_addProductToOrder = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.BTN_increment = new System.Windows.Forms.Button();
            this.BTN_decrement = new System.Windows.Forms.Button();
            this.TXTProductCount = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BOX_CompletedPay = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.LST_Selected = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXT_Delivery = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BTN_CompleteOrder = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // LST_customers
            // 
            this.LST_customers.FormattingEnabled = true;
            this.LST_customers.ItemHeight = 25;
            this.LST_customers.Location = new System.Drawing.Point(22, 49);
            this.LST_customers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LST_customers.Name = "LST_customers";
            this.LST_customers.Size = new System.Drawing.Size(280, 579);
            this.LST_customers.TabIndex = 0;
            this.LST_customers.SelectedIndexChanged += new System.EventHandler(this.LST_customers_SelectedIndexChanged);
            // 
            // LST_products
            // 
            this.LST_products.FormattingEnabled = true;
            this.LST_products.ItemHeight = 25;
            this.LST_products.Location = new System.Drawing.Point(28, 49);
            this.LST_products.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LST_products.Name = "LST_products";
            this.LST_products.Size = new System.Drawing.Size(406, 579);
            this.LST_products.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 220);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTN_manageCustomers);
            this.groupBox1.Controls.Add(this.LST_customers);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(48, 60);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(339, 814);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1. Select customer";
            // 
            // BTN_manageCustomers
            // 
            this.BTN_manageCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_manageCustomers.Location = new System.Drawing.Point(82, 694);
            this.BTN_manageCustomers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_manageCustomers.Name = "BTN_manageCustomers";
            this.BTN_manageCustomers.Size = new System.Drawing.Size(154, 72);
            this.BTN_manageCustomers.TabIndex = 1;
            this.BTN_manageCustomers.Text = "Manage Customers";
            this.BTN_manageCustomers.UseVisualStyleBackColor = true;
            this.BTN_manageCustomers.Click += new System.EventHandler(this.BTN_manageCustomers_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BTN_addProductToOrder);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.BTN_increment);
            this.groupBox2.Controls.Add(this.LST_products);
            this.groupBox2.Controls.Add(this.BTN_decrement);
            this.groupBox2.Controls.Add(this.TXTProductCount);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(452, 60);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(460, 823);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2. Select product(s)";
            // 
            // BTN_addProductToOrder
            // 
            this.BTN_addProductToOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_addProductToOrder.Location = new System.Drawing.Point(148, 751);
            this.BTN_addProductToOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_addProductToOrder.Name = "BTN_addProductToOrder";
            this.BTN_addProductToOrder.Size = new System.Drawing.Size(150, 54);
            this.BTN_addProductToOrder.TabIndex = 13;
            this.BTN_addProductToOrder.Text = "Add product to order";
            this.BTN_addProductToOrder.UseVisualStyleBackColor = true;
            this.BTN_addProductToOrder.Click += new System.EventHandler(this.BTN_addProductToOrder_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(148, 760);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 35);
            this.button4.TabIndex = 13;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // BTN_increment
            // 
            this.BTN_increment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_increment.Location = new System.Drawing.Point(279, 694);
            this.BTN_increment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_increment.Name = "BTN_increment";
            this.BTN_increment.Size = new System.Drawing.Size(51, 35);
            this.BTN_increment.TabIndex = 12;
            this.BTN_increment.Text = "+";
            this.BTN_increment.UseVisualStyleBackColor = true;
            this.BTN_increment.Click += new System.EventHandler(this.BTN_increment_Click);
            // 
            // BTN_decrement
            // 
            this.BTN_decrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_decrement.Location = new System.Drawing.Point(112, 694);
            this.BTN_decrement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_decrement.Name = "BTN_decrement";
            this.BTN_decrement.Size = new System.Drawing.Size(50, 35);
            this.BTN_decrement.TabIndex = 11;
            this.BTN_decrement.Text = "-";
            this.BTN_decrement.UseVisualStyleBackColor = true;
            this.BTN_decrement.Click += new System.EventHandler(this.BTN_decrement_Click);
            // 
            // TXTProductCount
            // 
            this.TXTProductCount.Location = new System.Drawing.Point(171, 697);
            this.TXTProductCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTProductCount.Name = "TXTProductCount";
            this.TXTProductCount.Size = new System.Drawing.Size(97, 30);
            this.TXTProductCount.TabIndex = 10;
            this.TXTProductCount.Text = "0";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.BOX_CompletedPay);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.LST_Selected);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.TXT_Delivery);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.BTN_CompleteOrder);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(1017, 60);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(538, 823);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "3. Examine and complete order";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(48, 311);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Completed payment?";
            // 
            // BOX_CompletedPay
            // 
            this.BOX_CompletedPay.AutoSize = true;
            this.BOX_CompletedPay.Location = new System.Drawing.Point(243, 311);
            this.BOX_CompletedPay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BOX_CompletedPay.Name = "BOX_CompletedPay";
            this.BOX_CompletedPay.Size = new System.Drawing.Size(22, 21);
            this.BOX_CompletedPay.TabIndex = 20;
            this.BOX_CompletedPay.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(165, 366);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Selected products";
            // 
            // LST_Selected
            // 
            this.LST_Selected.FormattingEnabled = true;
            this.LST_Selected.ItemHeight = 25;
            this.LST_Selected.Location = new System.Drawing.Point(32, 397);
            this.LST_Selected.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LST_Selected.Name = "LST_Selected";
            this.LST_Selected.Size = new System.Drawing.Size(480, 279);
            this.LST_Selected.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 257);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Deliver at:";
            // 
            // TXT_Delivery
            // 
            this.TXT_Delivery.Location = new System.Drawing.Point(156, 249);
            this.TXT_Delivery.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXT_Delivery.Name = "TXT_Delivery";
            this.TXT_Delivery.Size = new System.Drawing.Size(282, 30);
            this.TXT_Delivery.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(165, 220);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "<email>";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(165, 174);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "<phone>";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(165, 129);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "<name>";
            // 
            // BTN_CompleteOrder
            // 
            this.BTN_CompleteOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CompleteOrder.Location = new System.Drawing.Point(170, 723);
            this.BTN_CompleteOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTN_CompleteOrder.Name = "BTN_CompleteOrder";
            this.BTN_CompleteOrder.Size = new System.Drawing.Size(162, 72);
            this.BTN_CompleteOrder.TabIndex = 13;
            this.BTN_CompleteOrder.Text = "Complete order";
            this.BTN_CompleteOrder.UseVisualStyleBackColor = true;
            this.BTN_CompleteOrder.Click += new System.EventHandler(this.BTN_CompleteOrder_Click);
            // 
            // FRMCreateNewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1604, 911);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FRMCreateNewOrder";
            this.Text = "Create New Order";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LST_customers;
        private System.Windows.Forms.ListBox LST_products;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BTN_addProductToOrder;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button BTN_increment;
        private System.Windows.Forms.Button BTN_decrement;
        private System.Windows.Forms.TextBox TXTProductCount;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BTN_CompleteOrder;
        private System.Windows.Forms.Button BTN_manageCustomers;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox LST_Selected;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXT_Delivery;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox BOX_CompletedPay;
    }
}