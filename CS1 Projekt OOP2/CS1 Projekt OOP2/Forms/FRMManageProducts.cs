﻿using CS1_Projekt_OOP2.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS1_Projekt_OOP2.Forms
{
    public partial class FRMManageProducts : Form
    {
        private IWarehouse warehouse;
        public FRMManageProducts(IWarehouse wh)
        {
            InitializeComponent();
            warehouse = wh;
            warehouse.WarehouseChanged += UpdateTable;
            UpdateTable();

            ProductGridView.RowHeadersVisible = false;
            ProductGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductGridView.CellClick += new DataGridViewCellEventHandler(ProductGridView_CellClick);
            Bitmap bmp = CS1_Projekt_OOP2.Properties.Resources.packages;
            this.Icon = Icon.FromHandle(bmp.GetHicon());
        }

        public void ProductGridView_CellClick(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in ProductGridView.SelectedRows)
            {
                if (row.Cells[0].Value != null)
                {
                    TXT_editName.Text = row.Cells[1].Value.ToString();
                    TXT_editPrice.Text = row.Cells[2].Value.ToString();
                    TXT_editStock.Text = row.Cells[3].Value.ToString();
                    BTN_updateProductInfo.Enabled = true;
                }
            }
        }

        public void UpdateTable()
        {
            ProductGridView.Rows.Clear();
            ProductGridView.Columns.Clear();

            ProductGridView.Columns.Add("Col1", "Product ID");
            ProductGridView.Columns.Add("Col2", "Product name");
            ProductGridView.Columns.Add("Col3", "Price");
            ProductGridView.Columns.Add("Col4", "Stock");
            ProductGridView.Columns.Add("Col5", "Next restock");

            foreach (Product p in warehouse.Products)
            {
                ProductGridView.Rows.Add(p.Code, p.Name, p.Price, p.Stock, p.NextStocking);
            }
        }

        public void UpdateTable(IEnumerable<Product> products)
        {
            ProductGridView.Rows.Clear();
            ProductGridView.Columns.Clear();

            ProductGridView.Columns.Add("Col1", "Product ID");
            ProductGridView.Columns.Add("Col2", "Product name");
            ProductGridView.Columns.Add("Col3", "Price");
            ProductGridView.Columns.Add("Col4", "Stock");
            ProductGridView.Columns.Add("Col5", "Next restock");

            foreach (Product p in products)
            {
                ProductGridView.Rows.Add(p.Code, p.Name, p.Price, p.Stock, p.NextStocking);
            }
        }

        private void BTN_updateProductInfo_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in ProductGridView.SelectedRows)
            {
                if (row.Cells[0].Value != null)
                {
                    bool inputCorrect = true;


                    int productId = int.Parse(row.Cells[0].Value.ToString());
                    string updatedName = TXT_editName.Text;
                    double updatedPrice;
                    int updatedStock;
                   
                   
                    if (!double.TryParse(TXT_editPrice.Text, out updatedPrice))
                    {
                        inputCorrect = false;
                        MessageBox.Show("Please enter a numeric value as a price");
                    }

                    if (!int.TryParse(TXT_editStock.Text, out updatedStock))
                    {
                        inputCorrect = false;
                        MessageBox.Show("Please enter a number in the Stock field");
                    }

                    if (inputCorrect)
                    {
                        try
                        {
                            warehouse.UpdateProductInformation(productId, updatedName, updatedPrice, updatedStock);
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show(exception.Message);
                        }
                    }
                }
            }
        }

        private void BTN_createNewCustomer_Click(object sender, EventArgs e)
        {
            bool inputCorrect = true;
            string productName = TXT_newName.Text;
            double productPrice;
            int productStock;

            if (!double.TryParse(TXT_newPrice.Text, out productPrice))
            {
                inputCorrect = false;
                MessageBox.Show("Please enter a numeric value as a price");
            }

            if(!int.TryParse(TXT_newStock.Text, out productStock))
            {
                inputCorrect = false;
                MessageBox.Show("Please enter a number in the Stock field");
            }

            if (inputCorrect)
            {
                try
                {
                    warehouse.AddNewProduct(productName, productPrice, productStock);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }              
        }

        private void BTN_StockZero_Click(object sender, EventArgs e)
        {
            IEnumerable<Product> zeroStockProducts = warehouse.ReturnAllProductsWithZeroStock();
            UpdateTable(zeroStockProducts);
        }

        private void filterBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (filterBox1.Checked)
                UpdateTable(warehouse.ReturnAllProductsWithZeroStock());
            else 
                UpdateTable();
        }
    }
}
