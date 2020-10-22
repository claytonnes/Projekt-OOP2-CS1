using CS1_Projekt_OOP2.Interfaces;
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
    public partial class FRMCreateNewOrder : Form
    {
        private IWarehouse warehouse;
        public FRMCreateNewOrder(IWarehouse wh)
        { 
            InitializeComponent();
            warehouse = wh;
            UpdateCustomerList();
            UpdateProductList();
        }

        private void UpdateCustomerList()
        {
            LST_customers.Items.Clear();
            foreach (Customer c in warehouse.Customers)
            {
                LST_customers.Items.Add(c);
            }
        }

        private void UpdateProductList()
        {
            LST_products.Items.Clear();
            foreach(Product p in warehouse.Products)
            {
                LST_products.Items.Add(p);
            }
        }

        private void LST_customers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer c = LST_customers.SelectedItem as Customer;
            label6.Text = c.Name;
            label7.Text = c.Phone;
            label8.Text = c.Email;
        }

        private void BTN_addProductToOrder_Click(object sender, EventArgs e)
        {
            Product p = LST_products.SelectedItem as Product;
            int productCount = Int32.Parse(TXTProductCount.Text);
            LSTSelected.Items.Add(new OrderLine(p, productCount));

        }
    }
}
