namespace CS1_Projekt_OOP2
{
    partial class Form5
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
            this.BTNAdd = new System.Windows.Forms.Button();
            this.BTNUpdate = new System.Windows.Forms.Button();
            this.BTNArchivedOrders = new System.Windows.Forms.Button();
            this.BTNActiveOrders = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(666, 401);
            this.dataGridView1.TabIndex = 0;
            // 
            // BTNAdd
            // 
            this.BTNAdd.Location = new System.Drawing.Point(22, 503);
            this.BTNAdd.Name = "BTNAdd";
            this.BTNAdd.Size = new System.Drawing.Size(229, 59);
            this.BTNAdd.TabIndex = 1;
            this.BTNAdd.Text = "Add Customer Information";
            this.BTNAdd.UseVisualStyleBackColor = true;
            // 
            // BTNUpdate
            // 
            this.BTNUpdate.Location = new System.Drawing.Point(282, 503);
            this.BTNUpdate.Name = "BTNUpdate";
            this.BTNUpdate.Size = new System.Drawing.Size(224, 59);
            this.BTNUpdate.TabIndex = 2;
            this.BTNUpdate.Text = "Update Customer Information";
            this.BTNUpdate.UseVisualStyleBackColor = true;
            // 
            // BTNArchivedOrders
            // 
            this.BTNArchivedOrders.Location = new System.Drawing.Point(716, 85);
            this.BTNArchivedOrders.Name = "BTNArchivedOrders";
            this.BTNArchivedOrders.Size = new System.Drawing.Size(224, 59);
            this.BTNArchivedOrders.TabIndex = 3;
            this.BTNArchivedOrders.Text = "View Archived Orders";
            this.BTNArchivedOrders.UseVisualStyleBackColor = true;
            // 
            // BTNActiveOrders
            // 
            this.BTNActiveOrders.Location = new System.Drawing.Point(716, 169);
            this.BTNActiveOrders.Name = "BTNActiveOrders";
            this.BTNActiveOrders.Size = new System.Drawing.Size(224, 59);
            this.BTNActiveOrders.TabIndex = 4;
            this.BTNActiveOrders.Text = "View Active Orders";
            this.BTNActiveOrders.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 692);
            this.Controls.Add(this.BTNActiveOrders);
            this.Controls.Add(this.BTNArchivedOrders);
            this.Controls.Add(this.BTNUpdate);
            this.Controls.Add(this.BTNAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BTNAdd;
        private System.Windows.Forms.Button BTNUpdate;
        private System.Windows.Forms.Button BTNArchivedOrders;
        private System.Windows.Forms.Button BTNActiveOrders;
    }
}