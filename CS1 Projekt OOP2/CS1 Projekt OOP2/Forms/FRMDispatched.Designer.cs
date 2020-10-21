namespace CS1_Projekt_OOP2
{
    partial class FRMDispatched
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
            this.dispatchedDataGrid = new System.Windows.Forms.DataGridView();
            this.LBLDispatch = new System.Windows.Forms.Label();
            this.BTNClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dispatchedDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dispatchedDataGrid
            // 
            this.dispatchedDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dispatchedDataGrid.Location = new System.Drawing.Point(27, 81);
            this.dispatchedDataGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dispatchedDataGrid.Name = "dispatchedDataGrid";
            this.dispatchedDataGrid.RowHeadersWidth = 62;
            this.dispatchedDataGrid.RowTemplate.Height = 28;
            this.dispatchedDataGrid.Size = new System.Drawing.Size(306, 233);
            this.dispatchedDataGrid.TabIndex = 0;
            // 
            // LBLDispatch
            // 
            this.LBLDispatch.AutoSize = true;
            this.LBLDispatch.Location = new System.Drawing.Point(24, 55);
            this.LBLDispatch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBLDispatch.Name = "LBLDispatch";
            this.LBLDispatch.Size = new System.Drawing.Size(95, 13);
            this.LBLDispatch.TabIndex = 2;
            this.LBLDispatch.Text = "Dispatched Orders";
            // 
            // BTNClose
            // 
            this.BTNClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTNClose.Location = new System.Drawing.Point(635, 369);
            this.BTNClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNClose.Name = "BTNClose";
            this.BTNClose.Size = new System.Drawing.Size(56, 21);
            this.BTNClose.TabIndex = 3;
            this.BTNClose.Text = "Close";
            this.BTNClose.UseVisualStyleBackColor = true;
            // 
            // FRMDispatched
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 404);
            this.Controls.Add(this.BTNClose);
            this.Controls.Add(this.LBLDispatch);
            this.Controls.Add(this.dispatchedDataGrid);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FRMDispatched";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.FRMDispatched_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dispatchedDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dispatchedDataGrid;
        private System.Windows.Forms.Label LBLDispatch;
        private System.Windows.Forms.Button BTNClose;
    }
}