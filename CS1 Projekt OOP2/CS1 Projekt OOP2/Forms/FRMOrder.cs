using CS1_Projekt_OOP2.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS1_Projekt_OOP2
{
    public partial class FRMOrder : Form
    {
        private IWarehouse wh;
        public FRMOrder(IWarehouse wh)
        {
            this.wh = wh;
            InitializeComponent();
        }  

        private void BTNDispatchedOrders_Click(object sender, EventArgs e)
        {
            FRMDispatched GUIDispatchedOrders = new FRMDispatched(wh);
            GUIDispatchedOrders.ShowDialog();
        }

        private void BTNDpendingOrders_Click(object sender, EventArgs e)
        {
            FRMPendingOrders GUIPendingOrders = new FRMPendingOrders(wh);
            GUIPendingOrders.ShowDialog();
        }

        private void BTNCustomers_Click(object sender, EventArgs e)
        {
            FRMCustomers CustomersInformation = new FRMCustomers(wh);
            CustomersInformation.ShowDialog();
        }

        private void FRMOrder_Load(object sender, EventArgs e)
        {
        }
    }
}
