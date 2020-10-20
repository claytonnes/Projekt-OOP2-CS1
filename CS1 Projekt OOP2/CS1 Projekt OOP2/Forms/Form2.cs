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
    public partial class Form2 : Form
    {
        Form3 GUIDispatchedOrders = new Form3();
        Form4 GUIPendingOrders = new Form4();
        Form5 CustomersInformation = new Form5();
        public Form2()
        {
            InitializeComponent();
        }

      

        private void BTNDispatchedOrders_Click(object sender, EventArgs e)
        {
            GUIDispatchedOrders.Show();
        }

        private void BTNDpendingOrders_Click(object sender, EventArgs e)
        {
            GUIPendingOrders.Show();
        }

        private void BTNCustomers_Click(object sender, EventArgs e)
        {
            CustomersInformation.Show();
        }
    }
}
