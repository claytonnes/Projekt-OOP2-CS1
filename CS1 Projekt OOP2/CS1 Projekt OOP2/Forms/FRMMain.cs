using CS1_Projekt_OOP2.Forms;
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

namespace CS1_Projekt_OOP2
{
    public partial class FRMMain : Form
    {
        private IWarehouse wh;
        private FRMManageCustomers customerForm;
        private FRMManageProducts productForm;

        public FRMMain(IWarehouse wh)
        {
            this.wh = wh;
            InitializeComponent();
        }

        private void BTNNewOrder_Click(object sender, EventArgs e)
        {
            FRMCreateNewOrder GUIOrders = new FRMCreateNewOrder(wh);
            GUIOrders.ShowDialog();
        }

        private void FRMMain_Load(object sender, EventArgs e)
        {
            // Test-data
            wh.AddNewProduct("Shampoo", 43.50, 20);

            wh.AddNewCustomer("Moa", "012-34567", "test@test.com");
            List<OrderLine> items = new List<OrderLine>();
            OrderLine item = new OrderLine(wh.Products[0], 123);
            items.Add(item);
            wh.AddNewOrder(wh.Customers[0], "Leveransvägen 1", items, true);

            //Testdata för att visa att pending/dispatched-sorteringen fungerar.
            wh.AddNewOrder(wh.Customers[0], "Vägvägen11", items, true);
            wh.Orders[1].Dispatched = true;

            dataGridView1.DataSource = wh.Orders;
        }

        private void BTN_OpenFRMCustomers_Click(object sender, EventArgs e)
        {
            
        }

        private void BTN_OpenFRMCustomers_Click_1(object sender, EventArgs e)
        {
            if (customerForm != null)
            {
                customerForm.WindowState = FormWindowState.Normal;
                customerForm.Focus();
            }
            else
            {
                customerForm = new FRMManageCustomers(wh);
                customerForm.FormClosed += (o, ea) => customerForm = null;
                customerForm.Show();
            }
        }

        private void BTNProducts_Click(object sender, EventArgs e)
        {
            if (productForm != null)
            {
                productForm.WindowState = FormWindowState.Normal;
                productForm.Focus();
            }
            else
            {
                productForm = new FRMManageProducts(wh);
                productForm.FormClosed += (o, ea) => productForm = null;
                productForm.Show();
            }
        }
    }
}
