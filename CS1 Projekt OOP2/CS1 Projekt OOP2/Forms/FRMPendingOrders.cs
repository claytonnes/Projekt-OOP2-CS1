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
    public partial class FRMPendingOrders : Form
    {
        private IWarehouse wh;
        public FRMPendingOrders(IWarehouse wh)
        {
            this.wh = wh;
            InitializeComponent();
        }
    }
}
