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
    public partial class Form1 : Form
    {
       
        Form2 GUIOrders = new Form2(); 

        public Form1()
        {
            InitializeComponent();
        }

        private void BTNNewOrder_Click(object sender, EventArgs e)
        {
            GUIOrders.Show();
        }
    }
}
