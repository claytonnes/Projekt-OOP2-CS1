using CS1_Projekt_OOP2.Classes;
using CS1_Projekt_OOP2.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS1_Projekt_OOP2.Forms
{
    

    public partial class FRMCreateNewOrder : Form
    {
        private IWarehouse wh;
        private FRMManageCustomers customerForm;
        int productCount;
        private IWarehouse warehouse;
        private FRMMain FrmMain; 

        public FRMCreateNewOrder(FRMMain parent, IWarehouse wh)
        { 
            InitializeComponent();
            warehouse = wh;
            UpdateCustomerList();
            UpdateProductList();
            productCount = 0;
            warehouse.WarehouseChanged += UpdateCustomerList;
            warehouse.WarehouseChanged += UpdateProductList;
            this.FrmMain = parent; 

            Bitmap bmp = CS1_Projekt_OOP2.Properties.Resources.plus;
            this.Icon = Icon.FromHandle(bmp.GetHicon());
        }

        private void UpdateCustomerList()
        {
            LST_customers.Items.Clear();
            foreach (Customer c in warehouse.Customers)
            {
                LST_customers.Items.Add(c);
                label6.Text = "";
                label7.Text = "";
                label8.Text = "";
                TXT_Delivery.Clear();
                LST_Selected.Items.Clear();
                BOX_CompletedPay.Checked = false;
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
            if(LST_customers.SelectedItem != null)
            {
                Customer c = LST_customers.SelectedItem as Customer;
                label6.Text = c.Name;
                label7.Text = c.Phone;
                label8.Text = c.Email;
            }      
        }

        private void BTN_addProductToOrder_Click(object sender, EventArgs e)
        {
            try 
            {
                Product p = LST_products.SelectedItem as Product;
                if(p == null)
                {
                    MessageBox.Show("Choose a product");
                    return;
                }

                productCount = Int32.Parse(TXTProductCount.Text);
                LST_Selected.Items.Add(new OrderLine(p, productCount));
                productCount = 0;
                TXTProductCount.Text = productCount.ToString();
            }
            catch(Exception exception)
            {
                MessageBox.Show("Add number of products");
            }
            
        }

        private void BTN_CompleteOrder_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = LST_customers.SelectedItem as Customer;
                string deliveryAddress = TXT_Delivery.Text;
                bool payment = BOX_CompletedPay.Checked ? true : false;
                warehouse.AddNewOrder(customer, deliveryAddress, GetOrderlinesFromLST(), payment);
                MessageBox.Show("Order added!");
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            
            
        }

        //Method for getting added OrderLines from listbox.
        private List<OrderLine> GetOrderlinesFromLST()
        {
            List<OrderLine> products = new List<OrderLine>();
            foreach (OrderLine ol in LST_Selected.Items)
            {
                products.Add(ol);
            }
            return products;
        }

        private void BTN_increment_Click(object sender, EventArgs e)
        {
            productCount++;
            TXTProductCount.Text = productCount.ToString();

        }

        private void BTN_decrement_Click(object sender, EventArgs e)
        {
            productCount--;
            TXTProductCount.Text = productCount.ToString();
        }

        private void BTN_manageCustomers_Click(object sender, EventArgs e)
        {
            FrmMain.OpenFRMCustomers();
        }
    }
}
