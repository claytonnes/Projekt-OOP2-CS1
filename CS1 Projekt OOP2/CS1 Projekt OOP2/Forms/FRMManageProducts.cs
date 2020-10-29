using CS1_Projekt_OOP2.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS1_Projekt_OOP2.Forms
{

    /// <summary>
    /// Form class to enable a GUI for creating, updating and viewing Product information.
    /// </summary>
    public partial class FRMManageProducts : Form
    {
        private IWarehouse warehouse;

        /// <summary>
        /// Initializes an instance of the ManageProducts Form.
        /// </summary>
        /// <param name="wh"></param>
        public FRMManageProducts(IWarehouse wh)
        {
            InitializeComponent();
            warehouse = wh;
            warehouse.WarehouseChanged += UpdateTable;
            
            //Setting the form Icon
            Bitmap bmp = CS1_Projekt_OOP2.Properties.Resources.packages;
            this.Icon = Icon.FromHandle(bmp.GetHicon());

            //Configuring the form's datagridview objects.
            ProductGridView.RowHeadersVisible = false;
            ProductGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductGridView.CellClick += new DataGridViewCellEventHandler(ProductGridView_CellClick);
            UpdateTable();
        }

        private void ProductGridView_CellClick(object sender, EventArgs e)
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

        private void UpdateTable()
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

        private void UpdateTable(IEnumerable<Product> products)
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
                int productId = int.Parse(row.Cells[0].Value.ToString());
                bool nonEmpty = true;
                bool correctInput = true;
                string productName = TXT_editName.Text;
                double productPrice;
                int productStock;
                string feedbackString = "Input error: ";

                if (row.Cells[0].Value != null)
                {
                    if ((TXT_editName.Text == "" || TXT_editName.Text == null) ||
                        (TXT_editPrice.Text == "" || TXT_editPrice.Text == null) ||
                        (TXT_editStock.Text == "" || TXT_editStock.Text == null))
                    {
                        MessageBox.Show("Please fill out all fields: Name, Price, Stock");
                        nonEmpty = false;
                    }

                    if (!double.TryParse(TXT_editPrice.Text.Replace(',','.'), NumberStyles.Any, new CultureInfo("en-US"), out productPrice))
                    {
                        correctInput = false;
                        feedbackString += "\nPrice has to be a numeric value";
                    }

                    if (!int.TryParse(TXT_editStock.Text, out productStock))
                    {
                        correctInput = false;
                        feedbackString += "\nStock has to be an integer";
                    }

                    if (!correctInput && nonEmpty)
                    {
                        MessageBox.Show(feedbackString);
                    }
                    else if (correctInput && nonEmpty)
                    {
                        try
                        {
                            warehouse.UpdateProductInformation( productId, productName, productPrice, productStock);
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show(exception.Message);
                        }
                    }
                }
            }
        }

        private void BTN_createNewProduct_Click(object sender, EventArgs e)
        {
            bool nonEmpty = true;
            bool correctInput = true;
            string productName = TXT_newName.Text;
            double productPrice;
            int productStock;
            string feedbackString = "Input error: ";

            if ((TXT_newName.Text == "" || TXT_newName.Text == null)||
                (TXT_newPrice.Text == "" || TXT_newPrice.Text == null)||
                (TXT_newStock.Text == "" || TXT_newStock.Text == null))
            {
                MessageBox.Show("Please fill out all fields: Name, Price, Stock");
                nonEmpty = false;
            }

            if (!double.TryParse(TXT_newPrice.Text.Replace(',', '.'), NumberStyles.Any, new CultureInfo("en-US"), out productPrice ))
            {
                correctInput = false;
                feedbackString += "\nPrice has to be a numeric value";
            }

            if (!int.TryParse(TXT_newStock.Text, out productStock))
            {
                correctInput = false;
                feedbackString += "\nStock has to be an integer";
            }

            if(!correctInput && nonEmpty)
            {
                MessageBox.Show(feedbackString);
            }
            else if(correctInput && nonEmpty)
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
