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

        public FRMMain(IWarehouse wh)
        {
            this.wh = wh;
            InitializeComponent();
        }

        private void BTNNewOrder_Click(object sender, EventArgs e)
        {
            FRMOrder GUIOrders = new FRMOrder(wh);
            GUIOrders.ShowDialog();
        }

        private void FRMMain_Load(object sender, EventArgs e)
        {
            // Test-data
            Product product = new Product();
            product.Name = "Balsam";
            product.Price = 123;
            product.Stock = 100;

            wh.AddNewCustomer("Moa", "012-34567", "test@test.com");
            List<OrderLine> items = new List<OrderLine>();
            OrderLine item = new OrderLine(product, 123);
            items.Add(item);
            wh.AddNewOrder(wh.Customers[0], "Leveransvägen 1", items, true);

            dataGridView1.DataSource = wh.Orders;
        }
    }
}
