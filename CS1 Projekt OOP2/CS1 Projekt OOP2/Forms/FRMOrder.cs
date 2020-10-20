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
    public partial class FRMOrder : Form
    {
        FRMDispatched GUIDispatchedOrders = new FRMDispatched();
        FRMPendingOrders GUIPendingOrders = new FRMPendingOrders();
        FRMCustomers CustomersInformation = new FRMCustomers();
        public FRMOrder()
        {
            InitializeComponent();
        }

      

        private void BTNDispatchedOrders_Click(object sender, EventArgs e)
        {
            GUIDispatchedOrders.ShowDialog();
        }

        private void BTNDpendingOrders_Click(object sender, EventArgs e)
        {
            GUIPendingOrders.ShowDialog();
        }

        private void BTNCustomers_Click(object sender, EventArgs e)
        {
            CustomersInformation.ShowDialog();
        }
    }
}
