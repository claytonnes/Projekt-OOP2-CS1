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
        List<Order> orders = new List<Order>();


        FRMOrder GUIOrders = new FRMOrder(); 

        public FRMMain()
        {
            InitializeComponent();
        }

        private void BTNNewOrder_Click(object sender, EventArgs e)
        {
            GUIOrders.ShowDialog();
        }

        private void FRMMain_Load(object sender, EventArgs e)
        {

            // Test-data
            Product product = new Product();
            product.Name = "Balsam";
            product.Price = 123;
            product.Stock = 100;

            Customer customer = new Customer(1, "Moa", "012-34567", "test@test.com");
            List<OrderLine> items = new List<OrderLine>();
            OrderLine item = new OrderLine(product, 123);
            items.Add(item);
            Order order = new Order(1, customer, "Hemmavägen 1", items, false);
            orders.Add(order);

            dataGridView1.DataSource = orders;
        }
    }
}
