﻿namespace CS1_Projekt_OOP2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LBLDispatch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(459, 358);
            this.dataGridView1.TabIndex = 0;
            // 
            // LBLDispatch
            // 
            this.LBLDispatch.AutoSize = true;
            this.LBLDispatch.Location = new System.Drawing.Point(36, 85);
            this.LBLDispatch.Name = "LBLDispatch";
            this.LBLDispatch.Size = new System.Drawing.Size(142, 20);
            this.LBLDispatch.TabIndex = 2;
            this.LBLDispatch.Text = "Dispatched Orders";
            this.LBLDispatch.Click += new System.EventHandler(this.LBLDispatch_Click);
            // 
            // FRMDispatched
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 621);
            this.Controls.Add(this.LBLDispatch);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FRMDispatched";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LBLDispatch;
    }
}