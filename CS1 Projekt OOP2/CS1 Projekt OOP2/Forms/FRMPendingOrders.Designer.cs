namespace CS1_Projekt_OOP2
{
    partial class FRMPendingOrders
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
            this.pendingDataGrid = new System.Windows.Forms.DataGridView();
            this.LBLPendingOrders = new System.Windows.Forms.Label();
            this.BTNClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pendingDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // pendingDataGrid
            // 
            this.pendingDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pendingDataGrid.Location = new System.Drawing.Point(21, 81);
            this.pendingDataGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pendingDataGrid.Name = "pendingDataGrid";
            this.pendingDataGrid.RowHeadersWidth = 62;
            this.pendingDataGrid.RowTemplate.Height = 28;
            this.pendingDataGrid.Size = new System.Drawing.Size(341, 237);
            this.pendingDataGrid.TabIndex = 0;
            // 
            // LBLPendingOrders
            // 
            this.LBLPendingOrders.AutoSize = true;
            this.LBLPendingOrders.Location = new System.Drawing.Point(19, 58);
            this.LBLPendingOrders.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBLPendingOrders.Name = "LBLPendingOrders";
            this.LBLPendingOrders.Size = new System.Drawing.Size(80, 13);
            this.LBLPendingOrders.TabIndex = 1;
            this.LBLPendingOrders.Text = "Pending Orders";
            // 
            // BTNClose
            // 
            this.BTNClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTNClose.Location = new System.Drawing.Point(671, 363);
            this.BTNClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNClose.Name = "BTNClose";
            this.BTNClose.Size = new System.Drawing.Size(55, 21);
            this.BTNClose.TabIndex = 2;
            this.BTNClose.Text = "Close";
            this.BTNClose.UseVisualStyleBackColor = true;
            // 
            // FRMPendingOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 392);
            this.Controls.Add(this.BTNClose);
            this.Controls.Add(this.LBLPendingOrders);
            this.Controls.Add(this.pendingDataGrid);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FRMPendingOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.FRMPendingOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pendingDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView pendingDataGrid;
        private System.Windows.Forms.Label LBLPendingOrders;
        private System.Windows.Forms.Button BTNClose;
    }
}