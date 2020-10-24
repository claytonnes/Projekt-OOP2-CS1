namespace CS1_Projekt_OOP2.Forms
{
    partial class FRMViewOrder
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
            this.ItemListGridView = new System.Windows.Forms.DataGridView();
            this.LBL_paymentStatus = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LBL_customerEmail = new System.Windows.Forms.Label();
            this.LBL_deliveryAdress = new System.Windows.Forms.Label();
            this.LBL_customerPhone = new System.Windows.Forms.Label();
            this.LBL_customerName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LBL_orderDate = new System.Windows.Forms.Label();
            this.LBL_paymentCompleted = new System.Windows.Forms.Label();
            this.LBL_paymentRefunded = new System.Windows.Forms.Label();
            this.LBL_dispatched = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.LBL_orderNumber = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LBL_customerId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ItemListGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemListGridView
            // 
            this.ItemListGridView.AllowUserToAddRows = false;
            this.ItemListGridView.AllowUserToDeleteRows = false;
            this.ItemListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemListGridView.Location = new System.Drawing.Point(22, 230);
            this.ItemListGridView.Name = "ItemListGridView";
            this.ItemListGridView.ReadOnly = true;
            this.ItemListGridView.Size = new System.Drawing.Size(568, 323);
            this.ItemListGridView.TabIndex = 2;
            // 
            // LBL_paymentStatus
            // 
            this.LBL_paymentStatus.AutoSize = true;
            this.LBL_paymentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_paymentStatus.Location = new System.Drawing.Point(6, 81);
            this.LBL_paymentStatus.Name = "LBL_paymentStatus";
            this.LBL_paymentStatus.Size = new System.Drawing.Size(97, 13);
            this.LBL_paymentStatus.TabIndex = 27;
            this.LBL_paymentStatus.Text = "Payment status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Deliver at:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Phone:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Email:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LBL_customerId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.LBL_customerEmail);
            this.groupBox1.Controls.Add(this.LBL_deliveryAdress);
            this.groupBox1.Controls.Add(this.LBL_customerPhone);
            this.groupBox1.Controls.Add(this.LBL_customerName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(340, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 177);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer information";
            // 
            // LBL_customerEmail
            // 
            this.LBL_customerEmail.AutoSize = true;
            this.LBL_customerEmail.Location = new System.Drawing.Point(77, 107);
            this.LBL_customerEmail.Name = "LBL_customerEmail";
            this.LBL_customerEmail.Size = new System.Drawing.Size(41, 13);
            this.LBL_customerEmail.TabIndex = 30;
            this.LBL_customerEmail.Text = "label12";
            // 
            // LBL_deliveryAdress
            // 
            this.LBL_deliveryAdress.AutoSize = true;
            this.LBL_deliveryAdress.Location = new System.Drawing.Point(78, 151);
            this.LBL_deliveryAdress.Name = "LBL_deliveryAdress";
            this.LBL_deliveryAdress.Size = new System.Drawing.Size(41, 13);
            this.LBL_deliveryAdress.TabIndex = 29;
            this.LBL_deliveryAdress.Text = "label11";
            // 
            // LBL_customerPhone
            // 
            this.LBL_customerPhone.AutoSize = true;
            this.LBL_customerPhone.Location = new System.Drawing.Point(77, 77);
            this.LBL_customerPhone.Name = "LBL_customerPhone";
            this.LBL_customerPhone.Size = new System.Drawing.Size(35, 13);
            this.LBL_customerPhone.TabIndex = 28;
            this.LBL_customerPhone.Text = "label2";
            // 
            // LBL_customerName
            // 
            this.LBL_customerName.AutoSize = true;
            this.LBL_customerName.Location = new System.Drawing.Point(77, 48);
            this.LBL_customerName.Name = "LBL_customerName";
            this.LBL_customerName.Size = new System.Drawing.Size(35, 13);
            this.LBL_customerName.TabIndex = 27;
            this.LBL_customerName.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Refunded:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Dispatch status:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Order date:";
            // 
            // LBL_orderDate
            // 
            this.LBL_orderDate.AutoSize = true;
            this.LBL_orderDate.Location = new System.Drawing.Point(111, 57);
            this.LBL_orderDate.Name = "LBL_orderDate";
            this.LBL_orderDate.Size = new System.Drawing.Size(35, 13);
            this.LBL_orderDate.TabIndex = 32;
            this.LBL_orderDate.Text = "label1";
            // 
            // LBL_paymentCompleted
            // 
            this.LBL_paymentCompleted.AutoSize = true;
            this.LBL_paymentCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_paymentCompleted.Location = new System.Drawing.Point(111, 81);
            this.LBL_paymentCompleted.Name = "LBL_paymentCompleted";
            this.LBL_paymentCompleted.Size = new System.Drawing.Size(41, 13);
            this.LBL_paymentCompleted.TabIndex = 33;
            this.LBL_paymentCompleted.Text = "label2";
            // 
            // LBL_paymentRefunded
            // 
            this.LBL_paymentRefunded.AutoSize = true;
            this.LBL_paymentRefunded.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_paymentRefunded.Location = new System.Drawing.Point(111, 107);
            this.LBL_paymentRefunded.Name = "LBL_paymentRefunded";
            this.LBL_paymentRefunded.Size = new System.Drawing.Size(48, 13);
            this.LBL_paymentRefunded.TabIndex = 34;
            this.LBL_paymentRefunded.Text = "label11";
            // 
            // LBL_dispatched
            // 
            this.LBL_dispatched.AutoSize = true;
            this.LBL_dispatched.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_dispatched.Location = new System.Drawing.Point(111, 151);
            this.LBL_dispatched.Name = "LBL_dispatched";
            this.LBL_dispatched.Size = new System.Drawing.Size(48, 13);
            this.LBL_dispatched.TabIndex = 35;
            this.LBL_dispatched.Text = "label12";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "Order #:";
            // 
            // LBL_orderNumber
            // 
            this.LBL_orderNumber.AutoSize = true;
            this.LBL_orderNumber.Location = new System.Drawing.Point(111, 31);
            this.LBL_orderNumber.Name = "LBL_orderNumber";
            this.LBL_orderNumber.Size = new System.Drawing.Size(41, 13);
            this.LBL_orderNumber.TabIndex = 37;
            this.LBL_orderNumber.Text = "label14";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.LBL_dispatched);
            this.groupBox2.Controls.Add(this.LBL_orderNumber);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.LBL_paymentCompleted);
            this.groupBox2.Controls.Add(this.LBL_paymentStatus);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.LBL_orderDate);
            this.groupBox2.Controls.Add(this.LBL_paymentRefunded);
            this.groupBox2.Location = new System.Drawing.Point(22, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 177);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Products in order:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Id:";
            // 
            // LBL_customerId
            // 
            this.LBL_customerId.AutoSize = true;
            this.LBL_customerId.Location = new System.Drawing.Point(77, 23);
            this.LBL_customerId.Name = "LBL_customerId";
            this.LBL_customerId.Size = new System.Drawing.Size(35, 13);
            this.LBL_customerId.TabIndex = 32;
            this.LBL_customerId.Text = "label1";
            // 
            // FRMViewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 576);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ItemListGridView);
            this.Name = "FRMViewOrder";
            this.Text = "FRMViewOrder";
            ((System.ComponentModel.ISupportInitialize)(this.ItemListGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView ItemListGridView;
        private System.Windows.Forms.Label LBL_paymentStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LBL_customerEmail;
        private System.Windows.Forms.Label LBL_deliveryAdress;
        private System.Windows.Forms.Label LBL_customerPhone;
        private System.Windows.Forms.Label LBL_customerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LBL_orderDate;
        private System.Windows.Forms.Label LBL_paymentCompleted;
        private System.Windows.Forms.Label LBL_paymentRefunded;
        private System.Windows.Forms.Label LBL_dispatched;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label LBL_orderNumber;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBL_customerId;
        private System.Windows.Forms.Label label2;
    }
}