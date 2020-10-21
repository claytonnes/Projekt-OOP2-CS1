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
    public partial class FRMCustomers : Form
    {
        IWarehouse wh;
        public FRMCustomers(IWarehouse wh)
        {
            this.wh = wh;
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
